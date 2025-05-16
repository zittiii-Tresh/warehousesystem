using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using warehousesystem.GlobalConnection;
using warehousesystem.Model;
using DevExpress.XtraEditors;
using Dapper;
using DevExpress.XtraGrid.Views.Grid;

namespace warehousesystem.Forms
{
	public partial class CashierForm: DevExpress.XtraBars.Ribbon.RibbonForm
	{
        private static string connectionString = ConnectionString.ConnString;
        public CashierForm()
        {
            InitializeComponent();
            ListOfProduct();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }
        private DataTable ListOfProduct()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                        EXEC ProductPOSRetrieve;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcProducts.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }
        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int selectedRow = gvProducts.FocusedRowHandle;
            if (selectedRow < 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }
            string productID = gvProducts.GetRowCellValue(selectedRow, "ProductID")?.ToString();
            string productName = gvProducts.GetRowCellValue(selectedRow, "ProductName")?.ToString();
            string priceStr = gvProducts.GetRowCellValue(selectedRow, "ProductPrice")?.ToString();
            decimal price = decimal.TryParse(priceStr, out decimal p) ? p : 0;
            int quantity = 1;
            decimal total = price * quantity;

            DataTable cartTable = gcProductSales.DataSource as DataTable;
            if (cartTable == null)
            {
                cartTable = new DataTable();
                cartTable.Columns.Add("ProductID");
                cartTable.Columns.Add("Items");
                cartTable.Columns.Add("Quantity");
                cartTable.Columns.Add("Price");
                cartTable.Columns.Add("Total");
                gcProductSales.DataSource = cartTable;
            }
            DataRow newRow = cartTable.NewRow();
            newRow["Items"] = productName;
            newRow["ProductID"] = productID;
            newRow["Quantity"] = quantity;
            newRow["Price"] = price.ToString("0.00");
            newRow["Total"] = total.ToString("0.00");
            cartTable.Rows.Add(newRow);
            UpdateTotalAmount(cartTable);
            POSSplitControl.Collapsed = false;
        }
        private void UpdateTotalAmount(DataTable cartTable)
        {
            decimal sum = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                if (decimal.TryParse(row["Total"]?.ToString(), out decimal total))
                {
                    sum += total;
                }
            }
            lblTotalAmount.Text = sum.ToString("N2");
        }
        private void gvProductSales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Quantity")
            {
                int rowHandle = e.RowHandle;

                object idObj = gvProductSales.GetRowCellValue(rowHandle, "ProductID");
                object quantityObj = gvProductSales.GetRowCellValue(rowHandle, "Quantity");
                object priceObj = gvProductSales.GetRowCellValue(rowHandle, "Price");

                if (int.TryParse(quantityObj?.ToString(), out int quantity) &&
                    decimal.TryParse(priceObj?.ToString(), out decimal price))
                {
                    decimal total = quantity * price;
                    gvProductSales.SetRowCellValue(rowHandle, "Total", total);
                    DataTable cartTable = gcProductSales.DataSource as DataTable;
                    if (cartTable != null)
                    {
                        UpdateTotalAmount(cartTable);
                    }
                } 
            }
        }
        private void repositoryItemButtonCancel_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvProductSales.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                gvProductSales.DeleteRow(focusedRowHandle);
                DataTable cartTable = gcProductSales.DataSource as DataTable;
                if (cartTable != null)
                {
                    UpdateTotalAmount(cartTable);
                }
            }
        }
        public int GetCurrentStockQuantity(string productID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT StockQuantity FROM pro.Product WHERE ProductID = @ProductID";
                var parameters = new { ProductID = productID };
                int stockQuantity = connection.ExecuteScalar<int>(query, parameters);
                return stockQuantity;
            }
        }
        private void confirmBTN_Click(object sender, EventArgs e)
        {
            GridView view = gcProductSales.MainView as GridView;
            if (view == null) return;
            List<string> errorMessages = new List<string>();
            Dictionary<string, int> validSales = new Dictionary<string, int>();
            for (int i = 0; i < view.RowCount; i++)
            {
                var row = view.GetDataRow(i);
                if (row == null) continue;
                string productId = row["ProductID"]?.ToString();
                if (string.IsNullOrWhiteSpace(productId)) continue;

                if (!int.TryParse(row["Quantity"]?.ToString(), out int quantityToSubtract))
                {
                    errorMessages.Add($"Invalid quantity for Product ID {productId}.");
                    continue;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkQuery = "SELECT StockQuantity FROM pro.Product WHERE ProductID = @ProductID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@ProductID", productId);
                    object result = checkCmd.ExecuteScalar();
                    if (result == null)
                    {
                        errorMessages.Add($"Product ID {productId} not found.");
                        continue;
                    }
                    int currentStock = Convert.ToInt32(result);
                    if (quantityToSubtract > currentStock)
                    {
                        errorMessages.Add($"Not enough stock for Product ID {productId}. (Available: {currentStock}, Requested: {quantityToSubtract})");
                    }
                    else
                    {
                        validSales.Add(productId, quantityToSubtract);
                    }
                }
            }       
            if (errorMessages.Any())
            {
                MessageBox.Show("Cannot proceed with sale:\n" + string.Join("\n", errorMessages), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }       
            foreach (var item in validSales)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = @"
                                            UPDATE pro.Product
                                            SET StockQuantity = StockQuantity - @Quantity
                                            WHERE ProductID = @ProductID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@Quantity", item.Value);
                    updateCmd.Parameters.AddWithValue("@ProductID", item.Key);
                    updateCmd.ExecuteNonQuery();
                    UpdateStockStatus(item.Key);
                }
            }
            MessageBox.Show("Sales confirmed and inventory updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListOfProduct();
        }
        public bool UpdateStockQuantity(string productID, int newStockQuantity)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE pro.Product SET StockQuantity = @StockQuantity WHERE ProductID = @ProductID";
                var parameters = new { ProductID = productID, StockQuantity = newStockQuantity };
                int rowsAffected = connection.Execute(query, parameters);
                return rowsAffected > 0;
            }
        }
        private void UpdateStockStatus(string productID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                                SELECT StockQuantity, LowStockLevel
                                FROM pro.Product
                                WHERE ProductID = @ProductID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int stockQuantity = reader.GetInt32(0);
                        int lowStockLevel = reader.GetInt32(1);
                        string status;
                        if (stockQuantity == 0)
                            status = "Out of Stock";
                        else if (stockQuantity <= lowStockLevel)
                            status = "Low Stock";
                        else
                            status = "In Stock";
                        reader.Close();
                        string updateStatusQuery = @"
                                                    UPDATE pro.Product
                                                    SET StockStatus = @Status
                                                    WHERE ProductID = @ProductID";
                        SqlCommand updateCmd = new SqlCommand(updateStatusQuery, connection);
                        updateCmd.Parameters.AddWithValue("@Status", status);
                        updateCmd.Parameters.AddWithValue("@ProductID", productID);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
