using DevExpress.XtraEditors;
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
using warehousesystem.GlobalConnection;

namespace warehousesystem.Forms
{
    using Dapper;

    public partial class DashboardForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly string GlobalConnection = ConnectionString.ConnString;

        public DashboardForm()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            LoadStockCounts();
        }

        private void LoadStockCounts()
        {
            lcOutOfStock.Text = GetStockCount("Out of Stock").ToString();
            lcLowStock.Text = GetStockCount("Low Stock").ToString();

            ccBestSeller.Series["Series 1"].DataSource = BestSeller();
            ccTotalSale.Series["Series 1"].DataSource = TotalSale();
        }

        private int GetStockCount(string stockStatus)
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                string query = @"SELECT COUNT(DISTINCT p.ProductID) 
                                 FROM pro.Product p 
                                 WHERE p.StockStatus = @StockStatus;";

                return connection.QuerySingle<int>(query,new{StockStatus = stockStatus});
            }
        }

        public List<Model.BestProduct> BestSeller()
        {
            using (var connection = new SqlConnection(ConnectionString.ConnString))
            {
                connection.Open();

                string query = @"SELECT TOP 3 
                                    p.ProductID,  
                                    p.ProductName,  
                                    SUM(s.ProductQuantity) AS TotalQuantity,  
                                    RANK() OVER(ORDER BY SUM(s.ProductQuantity) DESC) AS Rank
                                 FROM dbo.Sale s
                                 LEFT JOIN pro.Product p ON s.ProductID = p.ProductID
                                 GROUP BY p.ProductID, p.ProductName
                                 ORDER BY Rank;";

                return connection.Query<Model.BestProduct>(query).ToList();
            }
        }

        public List<Model.TotalSales> TotalSale()
        {
            using (var connection = new SqlConnection(ConnectionString.ConnString))
            {
                connection.Open();

                string query = @"SELECT 
                                    FORMAT(DatePurchased, 'MMMM') AS Month,
                                    SUM(TotalAmount) AS TotalSale
                                 FROM dbo.Sale
                                 GROUP BY FORMAT(DatePurchased, 'MMMM')
                                 ORDER BY Month;";
                return connection.Query<Model.TotalSales>(query).ToList();
            }
        }
    }
}
