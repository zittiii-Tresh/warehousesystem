namespace warehousesystem.Forms
{
    partial class XtraForm1
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
            this.components = new System.ComponentModel.Container();
            this.cmbFilterGenerateSales = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            this.DatePurchased = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReferenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecordNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalLabel = new DevExpress.XtraEditors.LabelControl();
            this.gvSale = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcSale = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filterTotal = new DevExpress.XtraEditors.LabelControl();
            this.filterLabel = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnGenerateAllSales = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoxFilterSale = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcProductList = new DevExpress.XtraGrid.GridControl();
            this.gvProductList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilterGenerateSales.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxFilterSale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilterGenerateSales
            // 
            this.cmbFilterGenerateSales.Location = new System.Drawing.Point(760, 710);
            this.cmbFilterGenerateSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterGenerateSales.Name = "cmbFilterGenerateSales";
            this.cmbFilterGenerateSales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFilterGenerateSales.Properties.Items.AddRange(new object[] {
            "All Sales",
            "Daily Sales",
            "Weekly Sales",
            "Monthly Sales"});
            this.cmbFilterGenerateSales.Size = new System.Drawing.Size(254, 28);
            this.cmbFilterGenerateSales.TabIndex = 57;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(181)))), ((int)(((byte)(84)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 53);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sale";
            // 
            // sidePanel8
            // 
            this.sidePanel8.AllowResize = false;
            this.sidePanel8.BorderThickness = 0;
            this.sidePanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel8.Location = new System.Drawing.Point(0, 0);
            this.sidePanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel8.Name = "sidePanel8";
            this.sidePanel8.Size = new System.Drawing.Size(1287, 33);
            this.sidePanel8.TabIndex = 3;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.sidePanel1.Appearance.Options.UseBorderColor = true;
            this.sidePanel1.Controls.Add(this.dateLabel);
            this.sidePanel1.Controls.Add(this.sidePanel9);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.sidePanel8);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1287, 82);
            this.sidePanel1.TabIndex = 51;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // dateLabel
            // 
            this.dateLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateLabel.Appearance.Options.UseFont = true;
            this.dateLabel.Appearance.Options.UseForeColor = true;
            this.dateLabel.Appearance.Options.UseTextOptions = true;
            this.dateLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.dateLabel.Location = new System.Drawing.Point(1206, 33);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dateLabel.Size = new System.Drawing.Size(57, 38);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "date";
            // 
            // sidePanel9
            // 
            this.sidePanel9.AllowResize = false;
            this.sidePanel9.BorderThickness = 0;
            this.sidePanel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel9.Location = new System.Drawing.Point(1263, 33);
            this.sidePanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel9.Name = "sidePanel9";
            this.sidePanel9.Size = new System.Drawing.Size(24, 48);
            this.sidePanel9.TabIndex = 4;
            this.sidePanel9.Text = "sidePanel9";
            // 
            // DatePurchased
            // 
            this.DatePurchased.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePurchased.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DatePurchased.AppearanceCell.Options.UseFont = true;
            this.DatePurchased.AppearanceCell.Options.UseForeColor = true;
            this.DatePurchased.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePurchased.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.DatePurchased.AppearanceHeader.Options.UseFont = true;
            this.DatePurchased.AppearanceHeader.Options.UseForeColor = true;
            this.DatePurchased.Caption = "Date Purchased";
            this.DatePurchased.FieldName = "DatePurchased";
            this.DatePurchased.MinWidth = 21;
            this.DatePurchased.Name = "DatePurchased";
            this.DatePurchased.OptionsColumn.AllowEdit = false;
            this.DatePurchased.OptionsColumn.AllowFocus = false;
            this.DatePurchased.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.DatePurchased.Visible = true;
            this.DatePurchased.VisibleIndex = 4;
            this.DatePurchased.Width = 157;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmployeeID.AppearanceCell.Options.UseFont = true;
            this.EmployeeID.AppearanceCell.Options.UseForeColor = true;
            this.EmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.EmployeeID.AppearanceHeader.Options.UseFont = true;
            this.EmployeeID.AppearanceHeader.Options.UseForeColor = true;
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.MinWidth = 21;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.OptionsColumn.AllowEdit = false;
            this.EmployeeID.OptionsColumn.AllowFocus = false;
            this.EmployeeID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 3;
            this.EmployeeID.Width = 357;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalAmount.AppearanceCell.Options.UseFont = true;
            this.TotalAmount.AppearanceCell.Options.UseForeColor = true;
            this.TotalAmount.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.TotalAmount.AppearanceHeader.Options.UseFont = true;
            this.TotalAmount.AppearanceHeader.Options.UseForeColor = true;
            this.TotalAmount.Caption = "Total Amount";
            this.TotalAmount.FieldName = "TotalAmount";
            this.TotalAmount.MinWidth = 21;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.OptionsColumn.AllowEdit = false;
            this.TotalAmount.OptionsColumn.AllowFocus = false;
            this.TotalAmount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.TotalAmount.Visible = true;
            this.TotalAmount.VisibleIndex = 2;
            this.TotalAmount.Width = 168;
            // 
            // ReferenceNumber
            // 
            this.ReferenceNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceNumber.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ReferenceNumber.AppearanceCell.Options.UseFont = true;
            this.ReferenceNumber.AppearanceCell.Options.UseForeColor = true;
            this.ReferenceNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceNumber.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.ReferenceNumber.AppearanceHeader.Options.UseFont = true;
            this.ReferenceNumber.AppearanceHeader.Options.UseForeColor = true;
            this.ReferenceNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.ReferenceNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ReferenceNumber.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ReferenceNumber.Caption = "Reference Number";
            this.ReferenceNumber.FieldName = "ReferenceNumber";
            this.ReferenceNumber.MinWidth = 21;
            this.ReferenceNumber.Name = "ReferenceNumber";
            this.ReferenceNumber.OptionsColumn.AllowEdit = false;
            this.ReferenceNumber.OptionsColumn.AllowFocus = false;
            this.ReferenceNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ReferenceNumber.Visible = true;
            this.ReferenceNumber.VisibleIndex = 1;
            this.ReferenceNumber.Width = 170;
            // 
            // RecordNumber
            // 
            this.RecordNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordNumber.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RecordNumber.AppearanceCell.Options.UseFont = true;
            this.RecordNumber.AppearanceCell.Options.UseForeColor = true;
            this.RecordNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordNumber.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.RecordNumber.AppearanceHeader.Options.UseFont = true;
            this.RecordNumber.AppearanceHeader.Options.UseForeColor = true;
            this.RecordNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.RecordNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RecordNumber.Caption = "#";
            this.RecordNumber.FieldName = "RecordNumber";
            this.RecordNumber.MinWidth = 21;
            this.RecordNumber.Name = "RecordNumber";
            this.RecordNumber.OptionsColumn.AllowEdit = false;
            this.RecordNumber.OptionsColumn.AllowFocus = false;
            this.RecordNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.RecordNumber.Visible = true;
            this.RecordNumber.VisibleIndex = 0;
            this.RecordNumber.Width = 40;
            // 
            // totalLabel
            // 
            this.totalLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Appearance.Options.UseFont = true;
            this.totalLabel.Appearance.Options.UseForeColor = true;
            this.totalLabel.Location = new System.Drawing.Point(1079, 633);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(98, 18);
            this.totalLabel.TabIndex = 56;
            this.totalLabel.Text = "Total Amount";
            // 
            // gvSale
            // 
            this.gvSale.DetailHeight = 284;
            this.gvSale.GridControl = this.gcSale;
            this.gvSale.Name = "gvSale";
            this.gvSale.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // gcSale
            // 
            this.gcSale.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSale.Location = new System.Drawing.Point(23, 41);
            this.gcSale.MainView = this.gvSale;
            this.gcSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcSale.Name = "gcSale";
            this.gcSale.Size = new System.Drawing.Size(729, 480);
            this.gcSale.TabIndex = 38;
            this.gcSale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSale,
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcSale;
            this.gridView1.Name = "gridView1";
            // 
            // filterTotal
            // 
            this.filterTotal.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTotal.Appearance.ForeColor = System.Drawing.Color.Black;
            this.filterTotal.Appearance.Options.UseFont = true;
            this.filterTotal.Appearance.Options.UseForeColor = true;
            this.filterTotal.Location = new System.Drawing.Point(221, 11);
            this.filterTotal.Name = "filterTotal";
            this.filterTotal.Size = new System.Drawing.Size(24, 19);
            this.filterTotal.TabIndex = 51;
            this.filterTotal.Text = "100";
            // 
            // filterLabel
            // 
            this.filterLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Appearance.Options.UseFont = true;
            this.filterLabel.Location = new System.Drawing.Point(95, 34);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(280, 29);
            this.filterLabel.TabIndex = 49;
            this.filterLabel.Text = "Grand Total Of All Sales";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.panelControl3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(33)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Appearance.Options.UseBorderColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.filterTotal);
            this.panelControl3.Controls.Add(this.filterLabel);
            this.panelControl3.Location = new System.Drawing.Point(125, 435);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(459, 68);
            this.panelControl3.TabIndex = 50;
            // 
            // btnGenerateAllSales
            // 
            this.btnGenerateAllSales.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(173)))), ((int)(((byte)(75)))));
            this.btnGenerateAllSales.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAllSales.Appearance.Options.UseBackColor = true;
            this.btnGenerateAllSales.Appearance.Options.UseFont = true;
            this.btnGenerateAllSales.Location = new System.Drawing.Point(1020, 710);
            this.btnGenerateAllSales.Name = "btnGenerateAllSales";
            this.btnGenerateAllSales.Size = new System.Drawing.Size(157, 28);
            this.btnGenerateAllSales.TabIndex = 53;
            this.btnGenerateAllSales.Text = "Generate Sale Report";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.gcSale);
            this.panelControl1.Location = new System.Drawing.Point(0, 172);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(736, 566);
            this.panelControl1.TabIndex = 52;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.cmbBoxFilterSale);
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(706, 35);
            this.panelControl2.TabIndex = 47;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 18);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Filter By:";
            // 
            // cmbBoxFilterSale
            // 
            this.cmbBoxFilterSale.Location = new System.Drawing.Point(96, 4);
            this.cmbBoxFilterSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxFilterSale.Name = "cmbBoxFilterSale";
            this.cmbBoxFilterSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxFilterSale.Properties.Items.AddRange(new object[] {
            "All Sales",
            "Daily Sales",
            "Weekly Sales",
            "Monthly Sales"});
            this.cmbBoxFilterSale.Size = new System.Drawing.Size(254, 28);
            this.cmbBoxFilterSale.TabIndex = 45;
            // 
            // gcProductList
            // 
            this.gcProductList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProductList.Location = new System.Drawing.Point(751, 172);
            this.gcProductList.MainView = this.gvProductList;
            this.gcProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProductList.Name = "gcProductList";
            this.gcProductList.Size = new System.Drawing.Size(434, 452);
            this.gcProductList.TabIndex = 54;
            this.gcProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductList});
            // 
            // gvProductList
            // 
            this.gvProductList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductName,
            this.ProductQuantity,
            this.Total});
            this.gvProductList.DetailHeight = 284;
            this.gvProductList.GridControl = this.gcProductList;
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceCell.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseForeColor = true;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 21;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.OptionsColumn.AllowFocus = false;
            this.ProductName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 0;
            this.ProductName.Width = 357;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductQuantity.AppearanceCell.Options.UseFont = true;
            this.ProductQuantity.AppearanceCell.Options.UseForeColor = true;
            this.ProductQuantity.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.ProductQuantity.AppearanceHeader.Options.UseFont = true;
            this.ProductQuantity.AppearanceHeader.Options.UseForeColor = true;
            this.ProductQuantity.Caption = "Quantity";
            this.ProductQuantity.FieldName = "ProductQuantity";
            this.ProductQuantity.MinWidth = 21;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.OptionsColumn.AllowEdit = false;
            this.ProductQuantity.OptionsColumn.AllowFocus = false;
            this.ProductQuantity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductQuantity.Visible = true;
            this.ProductQuantity.VisibleIndex = 1;
            this.ProductQuantity.Width = 157;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Visible = true;
            this.Total.VisibleIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1001, 629);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 23);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "TOTAL: ";
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 742);
            this.Controls.Add(this.cmbFilterGenerateSales);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.btnGenerateAllSales);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcProductList);
            this.Controls.Add(this.labelControl2);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilterGenerateSales.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxFilterSale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbFilterGenerateSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraGrid.Columns.GridColumn DatePurchased;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn ReferenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn RecordNumber;
        private DevExpress.XtraEditors.LabelControl totalLabel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSale;
        private DevExpress.XtraGrid.GridControl gcSale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl filterTotal;
        private DevExpress.XtraEditors.LabelControl filterLabel;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGenerateAllSales;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxFilterSale;
        private DevExpress.XtraGrid.GridControl gcProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn ProductQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
    }
}