﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string _currentUser;
        public MainForm(string currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
     
            mainPC.Controls.Add(dashboardForm);
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

        private void cashierBTN_Click(object sender, EventArgs e)
        {
            CashierForm cashierControl = new CashierForm(_currentUser);
            cashierControl.Dock = DockStyle.Fill;
            cashierControl.Show();
        }

        private void salesBTN_Click(object sender, EventArgs e)
        {
            mainPC.Controls.Clear();  // Clear existing controls

            SaleForm saleControl = new SaleForm();
            saleControl.Dock = DockStyle.Fill; // Ensure it fills the panel

            // Optional: Force redraw (in case layout glitches)
            saleControl.Margin = new Padding(0); // Optional: removes any margin
            mainPC.Padding = new Padding(0);     // Optional: removes padding
            DashboardForm dashboardForm = new DashboardForm();
            mainPC.Controls.Add(saleControl);
            mainPC.Invalidate();  // Force control to refresh
            mainPC.Update();      // Apply changes immediately
        }
    }
}
