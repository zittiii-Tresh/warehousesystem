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
using warehousesystem.GlobalConnection;
using warehousesystem.Model;

namespace warehousesystem.Forms
{
    public partial class Staff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static string connectionString = ConnectionString.ConnString;
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

            string query = @"
                EXEC EmployeeProductDetails;";

            return GlobalFunction.FillTable(gcProduct, query);
        }

        private void teProductKeyword_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProduct.ApplyFindFilter(e.NewValue as string);
        }
    }
}