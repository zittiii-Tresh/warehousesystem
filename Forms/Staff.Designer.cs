namespace warehousesystem.Forms
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.btnStaff = new DevExpress.XtraEditors.SimpleButton();
            this.exitBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teProductKeyword = new DevExpress.XtraEditors.TextEdit();
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            this.sidePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teProductKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.sidePanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.btnStaff);
            this.sidePanel1.Controls.Add(this.exitBTN);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(84, 781);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // btnStaff
            // 
            this.btnStaff.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnStaff.Appearance.Options.UseBackColor = true;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.ImageOptions.Image")));
            this.btnStaff.Location = new System.Drawing.Point(0, 148);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(83, 112);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "simpleButton2";
            // 
            // exitBTN
            // 
            this.exitBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBTN.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.exitBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exitBTN.ImageOptions.SvgImage")));
            this.exitBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.exitBTN.Location = new System.Drawing.Point(0, 720);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.exitBTN.Size = new System.Drawing.Size(83, 61);
            this.exitBTN.TabIndex = 1;
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
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(83, 148);
            this.sidePanel2.TabIndex = 0;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel3
            // 
            this.sidePanel3.AllowResize = false;
            this.sidePanel3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.sidePanel3.Appearance.Options.UseBorderColor = true;
            this.sidePanel3.BorderThickness = 2;
            this.sidePanel3.Controls.Add(this.sidePanel4);
            this.sidePanel3.Controls.Add(this.labelControl1);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel3.Location = new System.Drawing.Point(84, 0);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1275, 131);
            this.sidePanel3.TabIndex = 3;
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Controls.Add(this.lblDate);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel4.Location = new System.Drawing.Point(1044, 0);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(231, 129);
            this.sidePanel4.TabIndex = 1;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDate.Location = new System.Drawing.Point(50, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 29);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "MAR 3, 2025";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(181)))), ((int)(((byte)(84)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(33, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(194, 79);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Staff";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(33, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(179, 39);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Search Keyword : ";
            // 
            // teProductKeyword
            // 
            this.teProductKeyword.Location = new System.Drawing.Point(196, 40);
            this.teProductKeyword.Name = "teProductKeyword";
            this.teProductKeyword.Properties.AutoHeight = false;
            this.teProductKeyword.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.teProductKeyword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("teStaffKeyword.Properties.ContextImageOptions.SvgImage")));
            this.teProductKeyword.Size = new System.Drawing.Size(349, 45);
            this.teProductKeyword.TabIndex = 1;
            this.teProductKeyword.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teProductKeyword_EditValueChanging);
            // 
            // gcProduct
            // 
            this.gcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduct.Location = new System.Drawing.Point(30, 15);
            this.gcProduct.MainView = this.gvProduct;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.Size = new System.Drawing.Size(1215, 514);
            this.gcProduct.TabIndex = 4;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            this.gcProduct.Load += new System.EventHandler(this.gcProduct_Load);
            // 
            // gvProduct
            // 
            this.gvProduct.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gvProduct.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductName,
            this.ProductType,
            this.StockQuantity,
            this.StockStatus,
            this.ProductLocation});
            this.gvProduct.GridControl = this.gcProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsView.ShowGroupPanel = false;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductName.AppearanceCell.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 0;
            this.ProductName.Width = 94;
            // 
            // ProductType
            // 
            this.ProductType.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductType.AppearanceCell.Options.UseForeColor = true;
            this.ProductType.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductType.Caption = "Product Type";
            this.ProductType.FieldName = "CategoryName";
            this.ProductType.MinWidth = 25;
            this.ProductType.Name = "ProductType";
            this.ProductType.Visible = true;
            this.ProductType.VisibleIndex = 1;
            this.ProductType.Width = 94;
            // 
            // StockQuantity
            // 
            this.StockQuantity.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockQuantity.AppearanceCell.Options.UseForeColor = true;
            this.StockQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.StockQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockQuantity.Caption = "No. of Stocks";
            this.StockQuantity.FieldName = "StockQuantity";
            this.StockQuantity.MinWidth = 25;
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.Visible = true;
            this.StockQuantity.VisibleIndex = 2;
            this.StockQuantity.Width = 94;
            // 
            // StockStatus
            // 
            this.StockStatus.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockStatus.AppearanceCell.Options.UseForeColor = true;
            this.StockStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.StockStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockStatus.Caption = "Stock Status";
            this.StockStatus.FieldName = "StockStatus";
            this.StockStatus.MinWidth = 25;
            this.StockStatus.Name = "StockStatus";
            this.StockStatus.Visible = true;
            this.StockStatus.VisibleIndex = 3;
            this.StockStatus.Width = 94;
            // 
            // ProductLocation
            // 
            this.ProductLocation.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductLocation.AppearanceCell.Options.UseForeColor = true;
            this.ProductLocation.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductLocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductLocation.Caption = "Product Location";
            this.ProductLocation.FieldName = "LocationID";
            this.ProductLocation.MinWidth = 25;
            this.ProductLocation.Name = "ProductLocation";
            this.ProductLocation.Visible = true;
            this.ProductLocation.VisibleIndex = 4;
            this.ProductLocation.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Controls.Add(this.sidePanel5);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(84, 131);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1275, 650);
            this.panelControl2.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gcProduct);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 91);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.panelControl1.Size = new System.Drawing.Size(1275, 559);
            this.panelControl1.TabIndex = 3;
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Controls.Add(this.teProductKeyword);
            this.sidePanel5.Controls.Add(this.labelControl3);
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel5.Location = new System.Drawing.Point(0, 0);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1275, 91);
            this.sidePanel5.TabIndex = 2;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // Staff
            // 
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 781);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Staff";
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible;
            this.Text = "Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teProductKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.sidePanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton btnStaff;
        private DevExpress.XtraEditors.SimpleButton exitBTN;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teProductKeyword;
        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn ProductType;
        private DevExpress.XtraGrid.Columns.GridColumn StockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
        private DevExpress.XtraGrid.Columns.GridColumn ProductLocation;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
    }
}