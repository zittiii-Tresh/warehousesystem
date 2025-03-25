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
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraSpellChecker.Parser;
using warehousesystem.Model;

namespace warehousesystem.Forms
{
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static string connectionString = @"Data Source = LAPTOP-FC9GSM04\SQLEXPRESS;Initial Catalog = SmartWareHouseDB;Integrated Security = True;";
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public string GenerateID(string position, int recordNumber)
        {
            string prefix = "";

            if (position == "Admin")
                prefix = "A";
            else if (position == "Staff")
                prefix = "S";
            else if (position == "Cashier")
                prefix = "C";

            int year = DateTime.Now.Year;

            string id = $"{prefix}{recordNumber}{year}";

            return id;
        }

        private int GetLatestRecordNumber()
        {
            int recordNumber = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT ISNULL(MAX(RecordNumber), 0) + 1 FROM emp.Employee";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        recordNumber = Convert.ToInt32(result);
                    }
                }
            }

            return recordNumber;
        }

        private static void RegisterEmployee(Model.Employee employees)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = @"
                                INSERT INTO emp.Employee (EmployeeID, 
                                                          PositionID, 
                                                          FirstName, 
                                                          MiddleName, 
                                                          LastName, 
                                                          NameExtension, 
                                                          DateHired, 
                                                          EmployeeStatus, 
                                                          Password, 
                                                          ContactNo)
                                VALUES (@EmployeeID, 
                                        @PositionID, 
                                        @FirstName, 
                                        @MiddleName, 
                                        @LastName, 
                                        @NameExtension, 
                                        @DateHired, 
                                        @EmployeeStatus, 
                                        @Password, 
                                        @ContactNo)";
                int rowsAffected = connection.Execute(query, employees);
            }
        }


        private void addBTN_Click(object sender, EventArgs e)
        {
            Model.Employee employees = new Model.Employee();

            employees.FirstName = firstnameTE.Text;
            employees.MiddleName = middlenameTE.Text;
            employees.LastName = lastnameTE.Text;
            employees.NameExtension = nameextensionTE.Text;
            employees.DateHired = DateTime.Now;
            employees.ContactNo = contactnoTE.Text;
            employees.Password = passwordTE.Text;

            int positionID = 0;
            switch (positionRG.SelectedIndex)
            {
                case 0:
                    positionID = 1; 
                    break;
                case 1:
                    positionID = 2;  
                    break;
                case 2:
                    positionID = 3;  
                    break;
            }
            employees.PositionID = positionID;

            var selectedStatus = statusRG.Properties.Items[statusRG.SelectedIndex].Description;
            employees.EmployeeStatus = selectedStatus == "Active" ? 1 : 0;

            int latestRecordNumber = GetLatestRecordNumber();

            string positionName = positionRG.Properties.Items[positionRG.SelectedIndex].Description;
            employees.EmployeeID = GenerateID(positionName, latestRecordNumber);

            RegisterEmployee(employees);

            XtraMessageBox.Show($"Employee Added!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

    }
}
