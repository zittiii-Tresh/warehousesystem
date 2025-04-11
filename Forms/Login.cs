using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace warehousesystem.Forms
{
    public partial class Login : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static string connectionString = @"Data Source = LAPTOP-NN71FQ8R\SQLEXPRESS;Initial Catalog = SmartWareHouseDB;Integrated Security = True;";
        public Login()
        {
            InitializeComponent();
            textEditPassword.Tag = "eyeopen";
            textEditPassword.Properties.UseSystemPasswordChar = true;
            textEditPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string employeeID = textEditUserName.Text.Trim();
            string password = textEditPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(textEditUserName.Text) || string.IsNullOrWhiteSpace(textEditPassword.Text))
            {
                XtraMessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM emp.Employee WHERE employeeID = @EmployeeID AND password = @Password";
                int userExists = connection.ExecuteScalar<int>(query, new
                {
                    EmployeeID = employeeID,
                    Password = password
                });

                if (userExists > 0)
                {
                    XtraMessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void textEditPassword_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var tagAction = textEditPassword.Tag?.ToString() ?? "eyeopen";

            if (tagAction == "eyeopen")
            {
                textEditPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1]; 
                textEditPassword.Tag = "eyeclose";
                textEditPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide (hashed) password
                textEditPassword.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0]; 
                textEditPassword.Tag = "eyeopen";
                textEditPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CashierForm cashier = new CashierForm();
            cashier.Show();
        }
    }
}
