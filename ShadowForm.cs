using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehousesystem
{
    public class ShadowForm : Form1
    {
        private Control targetControl; // The SidePanel (loginSP)
        private int shadowOffset = 5; // Adjust shadow size

        public ShadowForm(Control target)
        {
            this.targetControl = target;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.3;
            this.ShowInTaskbar = false;

            // Set initial size & position
            UpdateShadowPosition();

            // Subscribe to move events to follow the SidePanel
            targetControl.LocationChanged += (s, e) => UpdateShadowPosition();
            targetControl.SizeChanged += (s, e) => UpdateShadowPosition();
        }

        private void UpdateShadowPosition()
        {
            if (targetControl == null || targetControl.Parent == null)
                return;

            this.Bounds = new Rectangle(
                targetControl.Left + targetControl.Parent.Left + shadowOffset,
                targetControl.Top + targetControl.Parent.Top + shadowOffset,
                targetControl.Width,
                targetControl.Height
            );
        }
        //Comment ni amingming
    }
}