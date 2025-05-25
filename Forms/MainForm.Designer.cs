namespace warehousesystem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.cashierBTN = new DevExpress.XtraEditors.SimpleButton();
            this.salesBTN = new DevExpress.XtraEditors.SimpleButton();
            this.employeeBTN = new DevExpress.XtraEditors.SimpleButton();
            this.inventoryBTN = new DevExpress.XtraEditors.SimpleButton();
            this.dashboardBTN = new DevExpress.XtraEditors.SimpleButton();
            this.exitBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.mainPC = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPC)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.cashierBTN);
            this.sidePanel1.Controls.Add(this.salesBTN);
            this.sidePanel1.Controls.Add(this.employeeBTN);
            this.sidePanel1.Controls.Add(this.inventoryBTN);
            this.sidePanel1.Controls.Add(this.dashboardBTN);
            this.sidePanel1.Controls.Add(this.exitBTN);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(75, 802);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // cashierBTN
            // 
            this.cashierBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cashierBTN.Appearance.Options.UseBackColor = true;
            this.cashierBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashierBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cashierBTN.ImageOptions.Image")));
            this.cashierBTN.Location = new System.Drawing.Point(0, 649);
            this.cashierBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashierBTN.Name = "cashierBTN";
            this.cashierBTN.Size = new System.Drawing.Size(74, 91);
            this.cashierBTN.TabIndex = 6;
            this.cashierBTN.Text = "POS";
            this.cashierBTN.Click += new System.EventHandler(this.cashierBTN_Click);
            // 
            // salesBTN
            // 
            this.salesBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.salesBTN.Appearance.Options.UseBackColor = true;
            this.salesBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("salesBTN.ImageOptions.Image")));
            this.salesBTN.Location = new System.Drawing.Point(0, 558);
            this.salesBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salesBTN.Name = "salesBTN";
            this.salesBTN.Size = new System.Drawing.Size(74, 91);
            this.salesBTN.TabIndex = 5;
            this.salesBTN.Text = "Sales";
            // 
            // employeeBTN
            // 
            this.employeeBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.employeeBTN.Appearance.Options.UseBackColor = true;
            this.employeeBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("employeeBTN.ImageOptions.Image")));
            this.employeeBTN.Location = new System.Drawing.Point(0, 467);
            this.employeeBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeBTN.Name = "employeeBTN";
            this.employeeBTN.Size = new System.Drawing.Size(74, 91);
            this.employeeBTN.TabIndex = 4;
            this.employeeBTN.Text = "Employees";
            this.employeeBTN.Click += new System.EventHandler(this.employeeBTN_Click);
            // 
            // inventoryBTN
            // 
            this.inventoryBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.inventoryBTN.Appearance.Options.UseBackColor = true;
            this.inventoryBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBTN.ImageOptions.Image")));
            this.inventoryBTN.Location = new System.Drawing.Point(0, 376);
            this.inventoryBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryBTN.Name = "inventoryBTN";
            this.inventoryBTN.Size = new System.Drawing.Size(74, 91);
            this.inventoryBTN.TabIndex = 5;
            this.inventoryBTN.Text = "Inventory";
            this.inventoryBTN.Click += new System.EventHandler(this.inventoryBTN_Click);
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dashboardBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.dashboardBTN.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.dashboardBTN.Appearance.Options.UseBackColor = true;
            this.dashboardBTN.Appearance.Options.UseBorderColor = true;
            this.dashboardBTN.Appearance.Options.UseForeColor = true;
            this.dashboardBTN.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.dashboardBTN.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.dashboardBTN.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dashboardBTN.AppearanceHovered.Options.UseBackColor = true;
            this.dashboardBTN.AppearanceHovered.Options.UseBorderColor = true;
            this.dashboardBTN.AppearanceHovered.Options.UseForeColor = true;
            this.dashboardBTN.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dashboardBTN.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.dashboardBTN.AppearancePressed.Options.UseBackColor = true;
            this.dashboardBTN.AppearancePressed.Options.UseBorderColor = true;
            this.dashboardBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBTN.ImageOptions.Image")));
            this.dashboardBTN.Location = new System.Drawing.Point(0, 285);
            this.dashboardBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(74, 91);
            this.dashboardBTN.TabIndex = 1;
            this.dashboardBTN.Text = "Dashboard";
            // 
            // exitBTN
            // 
            this.exitBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.exitBTN.Appearance.Options.UseBackColor = true;
            this.exitBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBTN.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.exitBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exitBTN.ImageOptions.SvgImage")));
            this.exitBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.exitBTN.Location = new System.Drawing.Point(0, 745);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(74, 57);
            this.exitBTN.TabIndex = 1;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel2.BackgroundImage")));
            this.sidePanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(74, 285);
            this.sidePanel2.TabIndex = 0;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // mainPC
            // 
            this.mainPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPC.Location = new System.Drawing.Point(75, 0);
            this.mainPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPC.Name = "mainPC";
            this.mainPC.Size = new System.Drawing.Size(1224, 802);
            this.mainPC.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 802);
            this.Controls.Add(this.mainPC);
            this.Controls.Add(this.sidePanel1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SimpleButton exitBTN;
        private DevExpress.XtraEditors.SimpleButton salesBTN;
        private DevExpress.XtraEditors.SimpleButton dashboardBTN;
        private DevExpress.XtraEditors.SimpleButton employeeBTN;
        private DevExpress.XtraEditors.SimpleButton inventoryBTN;
        private DevExpress.XtraEditors.SimpleButton cashierBTN;
        private DevExpress.XtraEditors.PanelControl mainPC;
    }
}