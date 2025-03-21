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
using warehousesystem.Model;


namespace warehousesystem.Forms
{
    public partial class Register : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static string connectionString = @"Data Source = KUKUSHIBO\SQLEXPRESS;Initial Catalog = WarehouseSytem;Integrated Security = True;";
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(textEditEmployeeID.Text) ||
                    string.IsNullOrWhiteSpace(textEditUsername.Text) ||
                    string.IsNullOrWhiteSpace(textEditPassword.Text) ||
                    string.IsNullOrWhiteSpace(textEditConfirmPassword.Text)) // ✅ Added confirm password check
                {
                    XtraMessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string employeeID = textEditEmployeeID.Text.Trim();
                string username = textEditUsername.Text.Trim();
                string password = textEditPassword.Text.Trim();
                string confirmPassword = textEditConfirmPassword.Text.Trim();

                // ✅ Confirm password check
                if (password != confirmPassword)
                {
                    XtraMessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hash password
                string hashedPassword = HashPassword(password);

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if EmployeeID or Username already exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE EmployeeID = @EmployeeID OR Username = @Username";
                    int exists = connection.ExecuteScalar<int>(checkQuery, new { EmployeeID = employeeID, Username = username });

                    if (exists > 0)
                    {
                        XtraMessageBox.Show("EmployeeID or Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO users (EmployeeID, Username, Passwords_Hash) VALUES (@EmployeeID, @Username, @Passwords_Hash)";
                    int rowsAffected = connection.Execute(insertQuery, new
                    {
                        EmployeeID = employeeID,
                        Username = username,
                        Passwords_Hash = hashedPassword
                    });

                    if (rowsAffected > 0)
                    {
                        XtraMessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // ✅ Close form after successful registration
                    }
                    else
                    {
                        XtraMessageBox.Show("Registration failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Password hashing method
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

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}