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
        private static string connectionString = @"Data Source = KUKUSHIBO\SQLEXPRESS;Initial Catalog = WarehouseSytem;Integrated Security = True;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //private void simpleButtonLogIn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Validate input
        //        if (string.IsNullOrWhiteSpace(textEditUserName.Text) || string.IsNullOrWhiteSpace(textEditPassword.Text))
        //        {
        //            XtraMessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        string username = textEditUserName.Text.Trim();
        //        string password = textEditPassword.Text.Trim();

        //        // Hash the entered password 
        //        string hashedPassword = HashPassword(password);

        //        using (var connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            // Query to check if username & password match
        //            string query = "SELECT COUNT(*) FROM users WHERE Username = @Username AND Passwords_Hash = @Passwords_Hash";
        //            int userExists = connection.ExecuteScalar<int>(query, new
        //            {
        //                Username = username,
        //                Passwords_Hash = hashedPassword
        //            });

        //            if (userExists > 0)
        //            {
        //                XtraMessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            }
        //            else
        //            {
        //                XtraMessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Validate input
            //    if (string.IsNullOrWhiteSpace(textEditUserName.Text) || string.IsNullOrWhiteSpace(textEditPassword.Text))
            //    {
            //        XtraMessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    string username = textEditUserName.Text.Trim();
            //    string password = textEditPassword.Text.Trim();

            //    // Hash the entered password 
            //    string hashedPassword = HashPassword(password);

            //    using (var connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();

            //        // Query to check if username & password match
            //        string query = "SELECT COUNT(*) FROM users WHERE Username = @Username AND Passwords_Hash = @Passwords_Hash";
            //        int userExists = connection.ExecuteScalar<int>(query, new
            //        {
            //            Username = username,
            //            Passwords_Hash = hashedPassword
            //        });

            //        if (userExists > 0)
            //        {
            //            XtraMessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        }
            //        else
            //        {
            //            XtraMessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            MainForm mainForm = new MainForm();
            mainForm.Show();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CashierForm cashier = new CashierForm();
            cashier.Show();
        }
    }
 }
