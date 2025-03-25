﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace warehousesystem.Forms
{
    public partial class InventoryForm : DevExpress.XtraEditors.XtraUserControl
    {
        internal MainForm MdiParent;

        public InventoryForm()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

    }
}
