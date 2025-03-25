using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;

namespace warehousesystem.Forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryBTN_Click(object sender, EventArgs e)
        {
            mainPC.Controls.Clear();
            InventoryForm inventoryControl = new InventoryForm();
            inventoryControl.Dock = DockStyle.Fill; 

            mainPC.Controls.Add(inventoryControl);

        }

        private void employeeBTN_Click(object sender, EventArgs e)
        {
            mainPC.Controls.Clear();
            EmployeeForm employeeControl = new EmployeeForm();
            employeeControl.Dock = DockStyle.Fill;

            mainPC.Controls.Add(employeeControl);
        }
    }
}