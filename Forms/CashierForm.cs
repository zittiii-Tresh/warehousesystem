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

            string productName = gvProducts.GetRowCellValue(selectedRow, "ProductName")?.ToString();
            string priceStr = gvProducts.GetRowCellValue(selectedRow, "ProductPrice")?.ToString();
            decimal price = decimal.TryParse(priceStr, out decimal p) ? p : 0;
            int quantity = 1;
            decimal total = price * quantity;

            // Get or create cart table
            DataTable cartTable = gcProductSales.DataSource as DataTable;
            if (cartTable == null)
            {
                cartTable = new DataTable();
                cartTable.Columns.Add("Items");
                cartTable.Columns.Add("Quantity");
                cartTable.Columns.Add("Price");
                cartTable.Columns.Add("Total");
                gcProductSales.DataSource = cartTable;
            }

            // Add new row
            DataRow newRow = cartTable.NewRow();
            newRow["Items"] = productName;
            newRow["Quantity"] = quantity;
            newRow["Price"] = price.ToString("0.00");
            newRow["Total"] = total.ToString("0.00");
            cartTable.Rows.Add(newRow);

            // Update total amount label
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

            // Assuming your label is called "lblTotalAmount"
            lblTotalAmount.Text = sum.ToString("N2");
        }

        private void gvProductSales_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Quantity")
            {
                int rowHandle = e.RowHandle;

                object quantityObj = gvProductSales.GetRowCellValue(rowHandle, "Quantity");
                object priceObj = gvProductSales.GetRowCellValue(rowHandle, "Price");

                if (int.TryParse(quantityObj?.ToString(), out int quantity) &&
                    decimal.TryParse(priceObj?.ToString(), out decimal price))
                {
                    decimal total = quantity * price;
                    gvProductSales.SetRowCellValue(rowHandle, "Total", total);

                    // Recalculate and update total amount label
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

                // Refresh total after deletion
                DataTable cartTable = gcProductSales.DataSource as DataTable;
                if (cartTable != null)
                {
                    UpdateTotalAmount(cartTable);
                }
            }
        }
    }
}