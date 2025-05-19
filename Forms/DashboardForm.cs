using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehousesystem.Forms
{
    public partial class DashboardForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
