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

       
    }
}
