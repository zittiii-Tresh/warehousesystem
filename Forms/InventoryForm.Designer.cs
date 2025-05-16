namespace warehousesystem.Forms
{
    partial class InventoryForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.clearBTN = new DevExpress.XtraEditors.SimpleButton();
            this.suppliernoTE = new DevExpress.XtraEditors.TextEdit();
            this.suppliernameTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.producttypeaddBTN = new DevExpress.XtraEditors.SimpleButton();
            this.productidTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.deleteBTN = new DevExpress.XtraEditors.SimpleButton();
            this.updateBTN = new DevExpress.XtraEditors.SimpleButton();
            this.addBTN = new DevExpress.XtraEditors.SimpleButton();
            this.shelfLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.containerLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.aisleLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.productpriceTE = new DevExpress.XtraEditors.TextEdit();
            this.lowstocklevelTE = new DevExpress.XtraEditors.TextEdit();
            this.stocksTE = new DevExpress.XtraEditors.TextEdit();
            this.productnameTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.producttypeLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StockStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupplierNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LowStockLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productidTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aisleLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpriceTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevelTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeLUE.Properties)).BeginInit();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(181)))), ((int)(((byte)(84)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(241, 68);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Products";
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.sidePanel1.Appearance.Options.UseBorderColor = true;
            this.sidePanel1.Controls.Add(this.dateLabel);
            this.sidePanel1.Controls.Add(this.sidePanel9);
            this.sidePanel1.Controls.Add(this.sidePanel8);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1442, 113);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // dateLabel
            // 
            this.dateLabel.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateLabel.Appearance.Options.UseFont = true;
            this.dateLabel.Appearance.Options.UseForeColor = true;
            this.dateLabel.Appearance.Options.UseTextOptions = true;
            this.dateLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.dateLabel.Location = new System.Drawing.Point(1342, 32);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(10);
            this.dateLabel.Size = new System.Drawing.Size(72, 47);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "date";
            // 
            // sidePanel9
            // 
            this.sidePanel9.AllowResize = false;
            this.sidePanel9.BorderThickness = 0;
            this.sidePanel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel9.Location = new System.Drawing.Point(1414, 32);
            this.sidePanel9.Name = "sidePanel9";
            this.sidePanel9.Size = new System.Drawing.Size(28, 80);
            this.sidePanel9.TabIndex = 3;
            this.sidePanel9.Text = "sidePanel9";
            // 
            // sidePanel8
            // 
            this.sidePanel8.AllowResize = false;
            this.sidePanel8.BorderThickness = 0;
            this.sidePanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel8.Location = new System.Drawing.Point(0, 0);
            this.sidePanel8.Name = "sidePanel8";
            this.sidePanel8.Size = new System.Drawing.Size(1442, 32);
            this.sidePanel8.TabIndex = 2;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Controls.Add(this.clearBTN);
            this.sidePanel2.Controls.Add(this.suppliernoTE);
            this.sidePanel2.Controls.Add(this.suppliernameTE);
            this.sidePanel2.Controls.Add(this.labelControl8);
            this.sidePanel2.Controls.Add(this.producttypeaddBTN);
            this.sidePanel2.Controls.Add(this.productidTE);
            this.sidePanel2.Controls.Add(this.labelControl14);
            this.sidePanel2.Controls.Add(this.deleteBTN);
            this.sidePanel2.Controls.Add(this.updateBTN);
            this.sidePanel2.Controls.Add(this.addBTN);
            this.sidePanel2.Controls.Add(this.shelfLUE);
            this.sidePanel2.Controls.Add(this.containerLUE);
            this.sidePanel2.Controls.Add(this.aisleLUE);
            this.sidePanel2.Controls.Add(this.labelControl12);
            this.sidePanel2.Controls.Add(this.labelControl11);
            this.sidePanel2.Controls.Add(this.labelControl10);
            this.sidePanel2.Controls.Add(this.labelControl9);
            this.sidePanel2.Controls.Add(this.productpriceTE);
            this.sidePanel2.Controls.Add(this.lowstocklevelTE);
            this.sidePanel2.Controls.Add(this.stocksTE);
            this.sidePanel2.Controls.Add(this.productnameTE);
            this.sidePanel2.Controls.Add(this.labelControl7);
            this.sidePanel2.Controls.Add(this.labelControl6);
            this.sidePanel2.Controls.Add(this.labelControl5);
            this.sidePanel2.Controls.Add(this.labelControl4);
            this.sidePanel2.Controls.Add(this.labelControl3);
            this.sidePanel2.Controls.Add(this.labelControl2);
            this.sidePanel2.Controls.Add(this.producttypeLUE);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(0, 113);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(361, 687);
            this.sidePanel2.TabIndex = 30;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // clearBTN
            // 
            this.clearBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.clearBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.clearBTN.Appearance.Options.UseBackColor = true;
            this.clearBTN.Appearance.Options.UseBorderColor = true;
            this.clearBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearBTN.ImageOptions.Image")));
            this.clearBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.clearBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(33, 33);
            this.clearBTN.Location = new System.Drawing.Point(301, 612);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(43, 41);
            this.clearBTN.TabIndex = 78;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // suppliernoTE
            // 
            this.suppliernoTE.Location = new System.Drawing.Point(156, 375);
            this.suppliernoTE.Name = "suppliernoTE";
            this.suppliernoTE.Properties.AutoHeight = false;
            this.suppliernoTE.Size = new System.Drawing.Size(173, 26);
            this.suppliernoTE.TabIndex = 87;
            // 
            // suppliernameTE
            // 
            this.suppliernameTE.Location = new System.Drawing.Point(156, 330);
            this.suppliernameTE.Name = "suppliernameTE";
            this.suppliernameTE.Properties.AutoHeight = false;
            this.suppliernameTE.Size = new System.Drawing.Size(173, 26);
            this.suppliernameTE.TabIndex = 86;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(35, 381);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 17);
            this.labelControl8.TabIndex = 82;
            this.labelControl8.Text = "Supplier No.";
            // 
            // producttypeaddBTN
            // 
            this.producttypeaddBTN.Appearance.Options.UseTextOptions = true;
            this.producttypeaddBTN.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.producttypeaddBTN.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.producttypeaddBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.producttypeaddBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("producttypeaddBTN.ImageOptions.SvgImage")));
            this.producttypeaddBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.producttypeaddBTN.Location = new System.Drawing.Point(329, 148);
            this.producttypeaddBTN.Name = "producttypeaddBTN";
            this.producttypeaddBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.producttypeaddBTN.Size = new System.Drawing.Size(25, 26);
            this.producttypeaddBTN.TabIndex = 5;
            this.producttypeaddBTN.Click += new System.EventHandler(this.producttypeaddBTN_Click);
            // 
            // productidTE
            // 
            this.productidTE.Location = new System.Drawing.Point(156, 57);
            this.productidTE.Name = "productidTE";
            this.productidTE.Properties.AutoHeight = false;
            this.productidTE.Size = new System.Drawing.Size(173, 26);
            this.productidTE.TabIndex = 80;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(35, 63);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(72, 17);
            this.labelControl14.TabIndex = 79;
            this.labelControl14.Text = "Product ID:";
            // 
            // deleteBTN
            // 
            this.deleteBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.deleteBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.deleteBTN.Appearance.Options.UseBackColor = true;
            this.deleteBTN.Appearance.Options.UseBorderColor = true;
            this.deleteBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.ImageOptions.Image")));
            this.deleteBTN.Location = new System.Drawing.Point(212, 613);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.deleteBTN.Size = new System.Drawing.Size(89, 40);
            this.deleteBTN.TabIndex = 93;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.updateBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.updateBTN.Appearance.Options.UseBackColor = true;
            this.updateBTN.Appearance.Options.UseBorderColor = true;
            this.updateBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBTN.ImageOptions.Image")));
            this.updateBTN.Location = new System.Drawing.Point(121, 613);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(89, 40);
            this.updateBTN.TabIndex = 92;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.addBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.addBTN.Appearance.Options.UseBackColor = true;
            this.addBTN.Appearance.Options.UseBorderColor = true;
            this.addBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.ImageOptions.Image")));
            this.addBTN.Location = new System.Drawing.Point(28, 613);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(90, 40);
            this.addBTN.TabIndex = 91;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // shelfLUE
            // 
            this.shelfLUE.Location = new System.Drawing.Point(84, 561);
            this.shelfLUE.Name = "shelfLUE";
            this.shelfLUE.Properties.AutoHeight = false;
            this.shelfLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shelfLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shelf", "Shelf")});
            this.shelfLUE.Properties.DisplayMember = "Shelf";
            this.shelfLUE.Properties.NullText = "";
            this.shelfLUE.Properties.ValueMember = "Shelf";
            this.shelfLUE.Size = new System.Drawing.Size(83, 26);
            this.shelfLUE.TabIndex = 90;
            // 
            // containerLUE
            // 
            this.containerLUE.Location = new System.Drawing.Point(122, 517);
            this.containerLUE.Name = "containerLUE";
            this.containerLUE.Properties.AutoHeight = false;
            this.containerLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.containerLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container")});
            this.containerLUE.Properties.DisplayMember = "Container";
            this.containerLUE.Properties.NullText = "";
            this.containerLUE.Properties.ValueMember = "Container";
            this.containerLUE.Size = new System.Drawing.Size(83, 26);
            this.containerLUE.TabIndex = 89;
            // 
            // aisleLUE
            // 
            this.aisleLUE.Location = new System.Drawing.Point(84, 472);
            this.aisleLUE.Name = "aisleLUE";
            this.aisleLUE.Properties.AutoHeight = false;
            this.aisleLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aisleLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aisle", "Aisle")});
            this.aisleLUE.Properties.DisplayMember = "Aisle";
            this.aisleLUE.Properties.NullText = "";
            this.aisleLUE.Properties.ValueMember = "Aisle";
            this.aisleLUE.Size = new System.Drawing.Size(83, 26);
            this.aisleLUE.TabIndex = 88;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(36, 565);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(33, 17);
            this.labelControl12.TabIndex = 71;
            this.labelControl12.Text = "Shelf:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(36, 520);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(69, 17);
            this.labelControl11.TabIndex = 70;
            this.labelControl11.Text = "Container:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(36, 476);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 17);
            this.labelControl10.TabIndex = 69;
            this.labelControl10.Text = "Aisle:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(35, 430);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(124, 18);
            this.labelControl9.TabIndex = 68;
            this.labelControl9.Text = "Product Location";
            // 
            // productpriceTE
            // 
            this.productpriceTE.Location = new System.Drawing.Point(156, 284);
            this.productpriceTE.Name = "productpriceTE";
            this.productpriceTE.Properties.AutoHeight = false;
            this.productpriceTE.Size = new System.Drawing.Size(173, 26);
            this.productpriceTE.TabIndex = 85;
            // 
            // lowstocklevelTE
            // 
            this.lowstocklevelTE.Location = new System.Drawing.Point(156, 238);
            this.lowstocklevelTE.Name = "lowstocklevelTE";
            this.lowstocklevelTE.Properties.AutoHeight = false;
            this.lowstocklevelTE.Size = new System.Drawing.Size(173, 26);
            this.lowstocklevelTE.TabIndex = 84;
            // 
            // stocksTE
            // 
            this.stocksTE.Location = new System.Drawing.Point(156, 193);
            this.stocksTE.Name = "stocksTE";
            this.stocksTE.Properties.AutoHeight = false;
            this.stocksTE.Size = new System.Drawing.Size(173, 26);
            this.stocksTE.TabIndex = 83;
            // 
            // productnameTE
            // 
            this.productnameTE.Location = new System.Drawing.Point(156, 101);
            this.productnameTE.Name = "productnameTE";
            this.productnameTE.Properties.AutoHeight = false;
            this.productnameTE.Size = new System.Drawing.Size(173, 26);
            this.productnameTE.TabIndex = 81;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(35, 335);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 17);
            this.labelControl7.TabIndex = 59;
            this.labelControl7.Text = "Supplier Name:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(35, 290);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 17);
            this.labelControl6.TabIndex = 58;
            this.labelControl6.Text = "Product Price:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(35, 243);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 17);
            this.labelControl5.TabIndex = 57;
            this.labelControl5.Text = "Low Stock Level:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(35, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 17);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "No. of Stocks:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(35, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 17);
            this.labelControl3.TabIndex = 55;
            this.labelControl3.Text = "Product Type:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 17);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Product Name:";
            // 
            // producttypeLUE
            // 
            this.producttypeLUE.Location = new System.Drawing.Point(156, 147);
            this.producttypeLUE.Name = "producttypeLUE";
            this.producttypeLUE.Properties.AutoHeight = false;
            this.producttypeLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.producttypeLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryID", "CategoryID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name")});
            this.producttypeLUE.Properties.DisplayMember = "CategoryName";
            this.producttypeLUE.Properties.NullText = "";
            this.producttypeLUE.Properties.ValueMember = "CategoryID";
            this.producttypeLUE.Size = new System.Drawing.Size(173, 26);
            this.producttypeLUE.TabIndex = 82;
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.gcProducts);
            this.sidePanel3.Controls.Add(this.sidePanel7);
            this.sidePanel3.Controls.Add(this.sidePanel6);
            this.sidePanel3.Controls.Add(this.sidePanel5);
            this.sidePanel3.Controls.Add(this.sidePanel4);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(361, 113);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1081, 687);
            this.sidePanel3.TabIndex = 31;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // gcProducts
            // 
            this.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProducts.Location = new System.Drawing.Point(19, 51);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(1043, 608);
            this.gcProducts.TabIndex = 4;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductID,
            this.ProductName,
            this.CategoryName,
            this.StockQuantity,
            this.StockStatus,
            this.LocationID,
            this.ProductPrice,
            this.SupplierName,
            this.SupplierNo,
            this.LowStockLevel});
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvProducts_RowClick);
            this.gvProducts.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvProducts_RowCellStyle);
            // 
            // ProductID
            // 
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.ProductID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceCell.Options.UseForeColor = true;
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductID.Caption = "Product ID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 25;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.OptionsColumn.AllowFocus = false;
            this.ProductID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            this.ProductID.Width = 128;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.ProductName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceCell.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 25;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.OptionsColumn.AllowFocus = false;
            this.ProductName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 201;
            // 
            // CategoryName
            // 
            this.CategoryName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.CategoryName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CategoryName.AppearanceCell.Options.UseFont = true;
            this.CategoryName.AppearanceCell.Options.UseForeColor = true;
            this.CategoryName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.CategoryName.AppearanceHeader.Options.UseFont = true;
            this.CategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.CategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CategoryName.Caption = "Category";
            this.CategoryName.FieldName = "CategoryName";
            this.CategoryName.MinWidth = 25;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.AllowEdit = false;
            this.CategoryName.OptionsColumn.AllowFocus = false;
            this.CategoryName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 2;
            this.CategoryName.Width = 141;
            // 
            // StockQuantity
            // 
            this.StockQuantity.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.StockQuantity.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockQuantity.AppearanceCell.Options.UseFont = true;
            this.StockQuantity.AppearanceCell.Options.UseForeColor = true;
            this.StockQuantity.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.StockQuantity.AppearanceHeader.Options.UseFont = true;
            this.StockQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.StockQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockQuantity.Caption = "Quantity";
            this.StockQuantity.FieldName = "StockQuantity";
            this.StockQuantity.MinWidth = 25;
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.OptionsColumn.AllowEdit = false;
            this.StockQuantity.OptionsColumn.AllowFocus = false;
            this.StockQuantity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StockQuantity.Visible = true;
            this.StockQuantity.VisibleIndex = 4;
            this.StockQuantity.Width = 110;
            // 
            // StockStatus
            // 
            this.StockStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.StockStatus.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StockStatus.AppearanceCell.Options.UseFont = true;
            this.StockStatus.AppearanceCell.Options.UseForeColor = true;
            this.StockStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.StockStatus.AppearanceHeader.Options.UseFont = true;
            this.StockStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.StockStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockStatus.Caption = "Stock Status";
            this.StockStatus.FieldName = "StockStatus";
            this.StockStatus.MinWidth = 25;
            this.StockStatus.Name = "StockStatus";
            this.StockStatus.OptionsColumn.AllowEdit = false;
            this.StockStatus.OptionsColumn.AllowFocus = false;
            this.StockStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StockStatus.Visible = true;
            this.StockStatus.VisibleIndex = 5;
            this.StockStatus.Width = 162;
            // 
            // LocationID
            // 
            this.LocationID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.LocationID.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocationID.AppearanceCell.Options.UseFont = true;
            this.LocationID.AppearanceCell.Options.UseForeColor = true;
            this.LocationID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.LocationID.AppearanceHeader.Options.UseFont = true;
            this.LocationID.AppearanceHeader.Options.UseTextOptions = true;
            this.LocationID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LocationID.Caption = "Location";
            this.LocationID.FieldName = "LocationID";
            this.LocationID.MinWidth = 25;
            this.LocationID.Name = "LocationID";
            this.LocationID.OptionsColumn.AllowEdit = false;
            this.LocationID.OptionsColumn.AllowFocus = false;
            this.LocationID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LocationID.Visible = true;
            this.LocationID.VisibleIndex = 3;
            this.LocationID.Width = 104;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.ProductPrice.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductPrice.AppearanceCell.Options.UseFont = true;
            this.ProductPrice.AppearanceCell.Options.UseForeColor = true;
            this.ProductPrice.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ProductPrice.AppearanceHeader.Options.UseFont = true;
            this.ProductPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductPrice.Caption = "Price";
            this.ProductPrice.FieldName = "ProductPrice";
            this.ProductPrice.MinWidth = 25;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.OptionsColumn.AllowEdit = false;
            this.ProductPrice.OptionsColumn.AllowFocus = false;
            this.ProductPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductPrice.Visible = true;
            this.ProductPrice.VisibleIndex = 6;
            this.ProductPrice.Width = 152;
            // 
            // SupplierName
            // 
            this.SupplierName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.SupplierName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SupplierName.AppearanceCell.Options.UseFont = true;
            this.SupplierName.AppearanceCell.Options.UseForeColor = true;
            this.SupplierName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.SupplierName.AppearanceHeader.Options.UseFont = true;
            this.SupplierName.AppearanceHeader.Options.UseTextOptions = true;
            this.SupplierName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupplierName.Caption = "Supplier Name";
            this.SupplierName.FieldName = "SupplierName";
            this.SupplierName.MinWidth = 25;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.OptionsColumn.AllowEdit = false;
            this.SupplierName.OptionsColumn.AllowFocus = false;
            this.SupplierName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SupplierName.Visible = true;
            this.SupplierName.VisibleIndex = 7;
            this.SupplierName.Width = 158;
            // 
            // SupplierNo
            // 
            this.SupplierNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.SupplierNo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SupplierNo.AppearanceCell.Options.UseFont = true;
            this.SupplierNo.AppearanceCell.Options.UseForeColor = true;
            this.SupplierNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.SupplierNo.AppearanceHeader.Options.UseFont = true;
            this.SupplierNo.AppearanceHeader.Options.UseTextOptions = true;
            this.SupplierNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupplierNo.Caption = "Contact No.";
            this.SupplierNo.FieldName = "SupplierNo";
            this.SupplierNo.MinWidth = 25;
            this.SupplierNo.Name = "SupplierNo";
            this.SupplierNo.OptionsColumn.AllowEdit = false;
            this.SupplierNo.OptionsColumn.AllowFocus = false;
            this.SupplierNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SupplierNo.Visible = true;
            this.SupplierNo.VisibleIndex = 8;
            this.SupplierNo.Width = 179;
            // 
            // LowStockLevel
            // 
            this.LowStockLevel.Caption = "LowStockLevel";
            this.LowStockLevel.FieldName = "LowStockLevel";
            this.LowStockLevel.MinWidth = 25;
            this.LowStockLevel.Name = "LowStockLevel";
            this.LowStockLevel.Width = 94;
            // 
            // sidePanel7
            // 
            this.sidePanel7.AllowResize = false;
            this.sidePanel7.BorderThickness = 0;
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel7.Location = new System.Drawing.Point(1062, 51);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(19, 608);
            this.sidePanel7.TabIndex = 3;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // sidePanel6
            // 
            this.sidePanel6.AllowResize = false;
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel6.Location = new System.Drawing.Point(0, 51);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(19, 608);
            this.sidePanel6.TabIndex = 2;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel5.Location = new System.Drawing.Point(0, 659);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(1081, 28);
            this.sidePanel5.TabIndex = 1;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel4.Location = new System.Drawing.Point(0, 0);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1081, 51);
            this.sidePanel4.TabIndex = 0;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // InventoryForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "InventoryForm";
            this.Size = new System.Drawing.Size(1442, 800);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productidTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aisleLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpriceTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevelTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeLUE.Properties)).EndInit();
            this.sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SimpleButton clearBTN;
        private DevExpress.XtraEditors.SimpleButton deleteBTN;
        private DevExpress.XtraEditors.SimpleButton updateBTN;
        private DevExpress.XtraEditors.SimpleButton addBTN;
        private DevExpress.XtraEditors.LookUpEdit shelfLUE;
        private DevExpress.XtraEditors.LookUpEdit containerLUE;
        private DevExpress.XtraEditors.LookUpEdit aisleLUE;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit productpriceTE;
        private DevExpress.XtraEditors.TextEdit lowstocklevelTE;
        private DevExpress.XtraEditors.TextEdit stocksTE;
        private DevExpress.XtraEditors.TextEdit productnameTE;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit producttypeLUE;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton producttypeaddBTN;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit suppliernoTE;
        private DevExpress.XtraEditors.TextEdit suppliernameTE;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn StockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
        private DevExpress.XtraGrid.Columns.GridColumn ProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierNo;
        private DevExpress.XtraGrid.Columns.GridColumn LocationID;
        private DevExpress.XtraGrid.Columns.GridColumn LowStockLevel;
        public DevExpress.XtraEditors.TextEdit productidTE;
    }
}
