using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using warehousesystem.GlobalConnection;

namespace warehousesystem.Forms
{
    public partial class SaleForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static string connectionString = ConnectionString.ConnString;
        public SaleForm()
        {

            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();

            cmbBoxFilterSale.Properties.Items.Clear();
            cmbBoxFilterSale.Properties.Items.AddRange(new string[] {
                "All Sales",
                "Daily Sales",
                "Weekly Sales",
                "Monthly Sales"
            });

            cmbBoxFilterSale.SelectedIndex = 0;
            LoadSales("All Sales");

           
            gvSale.RowClick += gvSale_RowClick;
        }
        private void cmbBoxFilterSale_EditValueChanged(object sender, EventArgs e)
        {
            string selectedFilter = cmbBoxFilterSale.Text;
            LoadSales(selectedFilter);

            switch (selectedFilter)
            {
                case "All Sales":
                    filterLabel.Text = "Grand Total Of All Sales";
                    break;
                case "Daily Sales":
                    filterLabel.Text = "Total Sale This Day";
                    break;
                case "Weekly Sales":
                    filterLabel.Text = "Total Sale This Week";
                    break;
                case "Monthly Sales":
                    filterLabel.Text = "Total Sale This Month";
                    break;
                default:
                    filterLabel.Text = "Grand Total Of All Sales";
                    break;
            }
        }


        private void LoadSales(string filter)
        
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string baseQuery = @"
            SELECT 
                s.ReferenceNumber,
                MAX(s.TotalAmount) AS TotalAmount,
                e.EmployeeID,
                MAX(s.DatePurchased) AS DatePurchased
            FROM [dbo].[Sale] s
            LEFT JOIN [emp].[EmployeePerformance] ep ON s.ReferenceNumber = ep.ReferenceNumber
            LEFT JOIN emp.Employee e ON ep.EmployeeID = e.EmployeeID
        ";

                string whereClause = "";
                switch (filter)
                {
                    case "Daily Sales":
                        whereClause = "WHERE CAST(s.DatePurchased AS DATE) = CAST(GETDATE() AS DATE)";
                        break;
                    case "Weekly Sales":
                        whereClause = "WHERE DATEPART(ISO_WEEK, s.DatePurchased) = DATEPART(ISO_WEEK, GETDATE()) AND DATEPART(YEAR, s.DatePurchased) = DATEPART(YEAR, GETDATE())";
                        break;
                    case "Monthly Sales":
                        whereClause = "WHERE MONTH(s.DatePurchased) = MONTH(GETDATE()) AND YEAR(s.DatePurchased) = YEAR(GETDATE())";
                        break;
                }

                string groupByClause = "GROUP BY s.ReferenceNumber, e.EmployeeID";
                string orderByClause = "ORDER BY MAX(s.DatePurchased) DESC";

                string finalQuery = $"{baseQuery} {whereClause} {groupByClause} {orderByClause}";

                using (SqlDataAdapter adapter = new SqlDataAdapter(finalQuery, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gcSale.DataSource = dt;
                    //Total Sales
                    decimal grandTotal = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (decimal.TryParse(row["TotalAmount"]?.ToString(), out decimal amount))
                        {
                            grandTotal += amount;
                        }
                    }

                    filterTotal.Text = $"₱ {grandTotal:N2}";
                }
            }
        }

        private void gvSale_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gvSale.GetFocusedRowCellValue("ReferenceNumber") is string refNumber)
            {
                LoadProductList(refNumber);
            }
        }
        private void LoadProductList(string referenceNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                    SELECT 
                        p.ProductName,
                        s.ProductQuantity,
                        p.ProductPrice,
                        (s.ProductQuantity * p.ProductPrice) AS Total
                    FROM [dbo].[Sale] s
                    JOIN [pro].[Product] p ON s.ProductID = p.ProductID
                    WHERE s.ReferenceNumber = @ReferenceNumber";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ReferenceNumber", referenceNumber);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        gcProductList.DataSource = dt;

                        //for the total amount
                        decimal grandTotal = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (decimal.TryParse(row["Total"]?.ToString(), out decimal total))
                            {
                                grandTotal += total;
                            }
                        }

                        // Display the total in totalLabel
                        totalLabel.Text = $"₱ {grandTotal:N2}";
                    }
                }
            }
        }

       
    }
}
