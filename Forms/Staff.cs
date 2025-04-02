using DevExpress.XtraBars;
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

namespace warehousesystem.Forms
{
    public partial class Staff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static string connectionString = @"Data Source = LAPTOP-NN71FQ8R\SQLEXPRESS;Initial Catalog = SmartWareHouseDB;Integrated Security = True;";
        public Staff()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void gcProduct_Load(object sender, EventArgs e)
        {
            ListOfProduct();
        }
        private DataTable ListOfProduct()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                EXEC EmployeeProductDetails;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcProduct.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }

        private void teProductKeyword_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProduct.ApplyFindFilter(e.NewValue as string);
        }
    }
}