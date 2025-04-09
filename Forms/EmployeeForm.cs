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
        private string selectedEmployeeID;
        public EmployeeForm()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            FilterAllEmployees();
        }
        private DataTable FilterAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT [EmployeeID],
                                        [PositionID],
                                        [FirstName],
                                        [MiddleName],
                                        [LastName],
                                        [NameExtension],
                                        FirstName + ' ' + 
                                               CASE 
                                                   WHEN MiddleName = ' ' THEN LastName + ' ' + NameExtension
                                                   WHEN MiddleName IS NOT NULL THEN LEFT(MiddleName,1) + '. ' + LastName + ' ' + NameExtension 
                                                   ELSE LastName + ' ' + NameExtension
                                               END AS 'EmployeeName',
                                        [EmployeeStatus],
                                        [ContactNo],
                                        [RecordNumber],
                                        [Password]
                                    FROM [SmartWareHouseDB].[emp].[Employee]
                                    ORDER BY RecordNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcEmployee.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
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

            gcEmployee.DataSource = FilterAllEmployees();

            XtraMessageBox.Show($"Employee Added!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            firstnameTE.Text = string.Empty;
            middlenameTE.Text = string.Empty;
            lastnameTE.Text = string.Empty;
            nameextensionTE.Text = string.Empty;
            contactnoTE.Text = string.Empty;
            passwordTE.Text = string.Empty;
        }
        public bool UpdateEmployee(Model.Employee employee, string originalEmployeeID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var parameters = new
                {
                    OriginalEmployeeID = originalEmployeeID,
                    employee.EmployeeID,
                    employee.PositionID,
                    employee.FirstName,
                    employee.MiddleName,
                    employee.LastName,
                    employee.NameExtension,
                    employee.EmployeeStatus,
                    employee.Password,
                    employee.ContactNo
                };

                int rowsAffected = connection.Execute("UpdateEmployee", parameters, commandType: CommandType.StoredProcedure);

                if (rowsAffected > 0)
                {
                    XtraMessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("No record updated. EmployeeID may not exist.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployeeID))
            {
                XtraMessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (positionRG.SelectedIndex < 0)
            {
                XtraMessageBox.Show("Please select a position.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (statusRG.SelectedIndex < 0)
            {
                XtraMessageBox.Show("Please select a status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Model.Employee employee = new Model.Employee();

            int recordNumber = Convert.ToInt32(gvEmployee.GetFocusedRowCellValue("RecordNumber"));

            string positionName = positionRG.Properties.Items[positionRG.SelectedIndex].Description;

            string newEmployeeID = GenerateID(positionName, recordNumber);

            employee.EmployeeID = newEmployeeID;
            employee.FirstName = firstnameTE.Text;
            employee.MiddleName = middlenameTE.Text;
            employee.LastName = lastnameTE.Text;
            employee.NameExtension = nameextensionTE.Text;
            employee.ContactNo = contactnoTE.Text;
            employee.Password = passwordTE.Text;

            switch (positionRG.SelectedIndex)
            {
                case 0: employee.PositionID = 1; break;
                case 1: employee.PositionID = 2; break;
                case 2: employee.PositionID = 3; break;
            }

            var selectedStatus = statusRG.Properties.Items[statusRG.SelectedIndex].Description;
            employee.EmployeeStatus = selectedStatus == "Active" ? 1 : 0;

            bool isUpdated = UpdateEmployee(employee, selectedEmployeeID);

            if (isUpdated)
            {
                gcEmployee.DataSource = FilterAllEmployees();
                selectedEmployeeID = null;
            }
        }

        private void gvEmployee_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selectedEmployeeID = Convert.ToString(gvEmployee.GetFocusedRowCellValue("EmployeeID"));
            firstnameTE.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("FirstName"));
            middlenameTE.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("MiddleName"));
            lastnameTE.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("LastName"));
            nameextensionTE.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("NameExtension"));
            statusRG.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("EmployeeStatus"));
            passwordTE.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("Password"));
            contactnoTE.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("ContactNo"));
            positionRG.Text = Convert.ToString(gvEmployee.GetFocusedRowCellValue("PositionID"));

            int positionID = Convert.ToInt32(gvEmployee.GetFocusedRowCellValue("PositionID"));
            positionRG.SelectedIndex = positionID - 1;

            int statusID = Convert.ToInt32(gvEmployee.GetFocusedRowCellValue("EmployeeStatus"));
            statusRG.SelectedIndex = statusID - 1;
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show(
                         "Are you sure you want to delete this Employee?",
                         "Confirm Delete",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning
                         );

            if (dialogResult == DialogResult.Yes)
            {
                string deleteId = (string)gvEmployee.GetFocusedRowCellValue("EmployeeID");

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteEmployee = "DELETE FROM emp.Employee WHERE EmployeeID = @EmployeeID";

                    connection.Execute(deleteEmployee, new { EmployeeID = deleteId });

                    XtraMessageBox.Show("Employee successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gcEmployee.DataSource = FilterAllEmployees();
            }
            else
            {
                XtraMessageBox.Show("Delete action canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

