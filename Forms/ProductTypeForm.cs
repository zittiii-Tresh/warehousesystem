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
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Dapper;

namespace warehousesystem.Forms
{
	public partial class ProductTypeForm: DevExpress.XtraBars.Ribbon.RibbonForm
	{
        private static string connectionString = @"Data Source = LAPTOP-NN71FQ8R\SQLEXPRESS;Initial Catalog = SmartWareHouseDB;Integrated Security = True;";
        public event EventHandler CategoryAdded;
       
        public ProductTypeForm()
		{
            InitializeComponent();
		}

        private void categorysaveBTN_Click(object sender, EventArgs e)
        {
            Model.Category productType = new Model.Category();
            productType.CategoryName = categoryTE.Text;

            CategoryAdded?.Invoke(this, EventArgs.Empty);

            RegisterCategory(productType);
            XtraMessageBox.Show("Category Added Successfully!");

            categoryTE.Text = string.Empty;

        }

        private static void RegisterCategory(Model.Category category)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"
                                INSERT INTO pro.ProductCategory (CategoryName)
                                VALUES (@CategoryName)";
                int rowsAffected = connection.Execute(query, category);
            }
        }



    }
}