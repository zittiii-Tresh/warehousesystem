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
            this.producttypeLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.productnameTE = new DevExpress.XtraEditors.TextEdit();
            this.stocksTE = new DevExpress.XtraEditors.TextEdit();
            this.lowstocklevelTE = new DevExpress.XtraEditors.TextEdit();
            this.productpriceTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.aisleLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.containerLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.shelfLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.addBTN = new DevExpress.XtraEditors.SimpleButton();
            this.updateBTN = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.productidTE = new DevExpress.XtraEditors.TextEdit();
            this.producttypeaddBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.suppliernameTE = new DevExpress.XtraEditors.TextEdit();
            this.suppliernoTE = new DevExpress.XtraEditors.TextEdit();
            this.clearBTN = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
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
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevelTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpriceTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aisleLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productidTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernoTE.Properties)).BeginInit();
            this.sidePanel2.SuspendLayout();
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
            this.labelControl1.Location = new System.Drawing.Point(24, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 55);
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
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1236, 92);
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
            this.dateLabel.Location = new System.Drawing.Point(1153, 26);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dateLabel.Size = new System.Drawing.Size(59, 38);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "date";
            // 
            // sidePanel9
            // 
            this.sidePanel9.AllowResize = false;
            this.sidePanel9.BorderThickness = 0;
            this.sidePanel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel9.Location = new System.Drawing.Point(1212, 26);
            this.sidePanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel9.Name = "sidePanel9";
            this.sidePanel9.Size = new System.Drawing.Size(24, 65);
            this.sidePanel9.TabIndex = 3;
            this.sidePanel9.Text = "sidePanel9";
            // 
            // sidePanel8
            // 
            this.sidePanel8.AllowResize = false;
            this.sidePanel8.BorderThickness = 0;
            this.sidePanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel8.Location = new System.Drawing.Point(0, 0);
            this.sidePanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel8.Name = "sidePanel8";
            this.sidePanel8.Size = new System.Drawing.Size(1236, 26);
            this.sidePanel8.TabIndex = 2;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // producttypeLUE
            // 
            this.producttypeLUE.Location = new System.Drawing.Point(134, 119);
            this.producttypeLUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.producttypeLUE.Name = "producttypeLUE";
            this.producttypeLUE.Properties.AutoHeight = false;
            this.producttypeLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.producttypeLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryID", "CategoryID", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.producttypeLUE.Properties.DisplayMember = "CategoryName";
            this.producttypeLUE.Properties.NullText = "";
            this.producttypeLUE.Properties.ValueMember = "CategoryID";
            this.producttypeLUE.Size = new System.Drawing.Size(148, 21);
            this.producttypeLUE.TabIndex = 82;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 86);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 15);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "Product Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 124);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 15);
            this.labelControl3.TabIndex = 55;
            this.labelControl3.Text = "Product Type:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 161);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 15);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "No. of Stocks:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(30, 197);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 15);
            this.labelControl5.TabIndex = 57;
            this.labelControl5.Text = "Low Stock Level:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(30, 236);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 15);
            this.labelControl6.TabIndex = 58;
            this.labelControl6.Text = "Product Price:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(30, 272);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 15);
            this.labelControl7.TabIndex = 59;
            this.labelControl7.Text = "Supplier Name:";
            // 
            // productnameTE
            // 
            this.productnameTE.Location = new System.Drawing.Point(134, 82);
            this.productnameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productnameTE.Name = "productnameTE";
            this.productnameTE.Properties.AutoHeight = false;
            this.productnameTE.Size = new System.Drawing.Size(148, 21);
            this.productnameTE.TabIndex = 81;
            // 
            // stocksTE
            // 
            this.stocksTE.Location = new System.Drawing.Point(134, 157);
            this.stocksTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocksTE.Name = "stocksTE";
            this.stocksTE.Properties.AutoHeight = false;
            this.stocksTE.Size = new System.Drawing.Size(148, 21);
            this.stocksTE.TabIndex = 83;
            // 
            // lowstocklevelTE
            // 
            this.lowstocklevelTE.Location = new System.Drawing.Point(134, 193);
            this.lowstocklevelTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowstocklevelTE.Name = "lowstocklevelTE";
            this.lowstocklevelTE.Properties.AutoHeight = false;
            this.lowstocklevelTE.Size = new System.Drawing.Size(148, 21);
            this.lowstocklevelTE.TabIndex = 84;
            // 
            // productpriceTE
            // 
            this.productpriceTE.Location = new System.Drawing.Point(134, 231);
            this.productpriceTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productpriceTE.Name = "productpriceTE";
            this.productpriceTE.Properties.AutoHeight = false;
            this.productpriceTE.Size = new System.Drawing.Size(148, 21);
            this.productpriceTE.TabIndex = 85;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(30, 349);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(98, 16);
            this.labelControl9.TabIndex = 68;
            this.labelControl9.Text = "Product Location";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(31, 387);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(25, 15);
            this.labelControl10.TabIndex = 69;
            this.labelControl10.Text = "Aisle:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(31, 422);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(53, 15);
            this.labelControl11.TabIndex = 70;
            this.labelControl11.Text = "Container:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(31, 459);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(26, 15);
            this.labelControl12.TabIndex = 71;
            this.labelControl12.Text = "Shelf:";
            // 
            // aisleLUE
            // 
            this.aisleLUE.Location = new System.Drawing.Point(72, 384);
            this.aisleLUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aisleLUE.Name = "aisleLUE";
            this.aisleLUE.Properties.AutoHeight = false;
            this.aisleLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.aisleLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Aisle", "Aisle", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.aisleLUE.Properties.DisplayMember = "Aisle";
            this.aisleLUE.Properties.NullText = "";
            this.aisleLUE.Properties.ValueMember = "Aisle";
            this.aisleLUE.Size = new System.Drawing.Size(71, 21);
            this.aisleLUE.TabIndex = 88;
            // 
            // containerLUE
            // 
            this.containerLUE.Location = new System.Drawing.Point(105, 420);
            this.containerLUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containerLUE.Name = "containerLUE";
            this.containerLUE.Properties.AutoHeight = false;
            this.containerLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.containerLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.containerLUE.Properties.DisplayMember = "Container";
            this.containerLUE.Properties.NullText = "";
            this.containerLUE.Properties.ValueMember = "Container";
            this.containerLUE.Size = new System.Drawing.Size(71, 21);
            this.containerLUE.TabIndex = 89;
            // 
            // shelfLUE
            // 
            this.shelfLUE.Location = new System.Drawing.Point(72, 456);
            this.shelfLUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shelfLUE.Name = "shelfLUE";
            this.shelfLUE.Properties.AutoHeight = false;
            this.shelfLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shelfLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shelf", "Shelf", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.shelfLUE.Properties.DisplayMember = "Shelf";
            this.shelfLUE.Properties.NullText = "";
            this.shelfLUE.Properties.ValueMember = "Shelf";
            this.shelfLUE.Size = new System.Drawing.Size(71, 21);
            this.shelfLUE.TabIndex = 90;
            // 
            // addBTN
            // 
            this.addBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.addBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.addBTN.Appearance.Options.UseBackColor = true;
            this.addBTN.Appearance.Options.UseBorderColor = true;
            this.addBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.ImageOptions.Image")));
            this.addBTN.Location = new System.Drawing.Point(24, 498);
            this.addBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(77, 32);
            this.addBTN.TabIndex = 91;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.updateBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.updateBTN.Appearance.Options.UseBackColor = true;
            this.updateBTN.Appearance.Options.UseBorderColor = true;
            this.updateBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBTN.ImageOptions.Image")));
            this.updateBTN.Location = new System.Drawing.Point(104, 498);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(76, 32);
            this.updateBTN.TabIndex = 92;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.deleteBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.deleteBTN.Appearance.Options.UseBackColor = true;
            this.deleteBTN.Appearance.Options.UseBorderColor = true;
            this.deleteBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.ImageOptions.Image")));
            this.deleteBTN.Location = new System.Drawing.Point(182, 498);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.deleteBTN.Size = new System.Drawing.Size(76, 32);
            this.deleteBTN.TabIndex = 93;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(30, 51);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(55, 15);
            this.labelControl14.TabIndex = 79;
            this.labelControl14.Text = "Product ID:";
            // 
            // productidTE
            // 
            this.productidTE.Location = new System.Drawing.Point(134, 46);
            this.productidTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productidTE.Name = "productidTE";
            this.productidTE.Properties.AutoHeight = false;
            this.productidTE.Size = new System.Drawing.Size(148, 21);
            this.productidTE.TabIndex = 80;
            // 
            // producttypeaddBTN
            // 
            this.producttypeaddBTN.Appearance.Options.UseTextOptions = true;
            this.producttypeaddBTN.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.producttypeaddBTN.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.producttypeaddBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.producttypeaddBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("producttypeaddBTN.ImageOptions.SvgImage")));
            this.producttypeaddBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.producttypeaddBTN.Location = new System.Drawing.Point(282, 120);
            this.producttypeaddBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.producttypeaddBTN.Name = "producttypeaddBTN";
            this.producttypeaddBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.producttypeaddBTN.Size = new System.Drawing.Size(21, 21);
            this.producttypeaddBTN.TabIndex = 5;
            this.producttypeaddBTN.Click += new System.EventHandler(this.producttypeaddBTN_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(30, 310);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 15);
            this.labelControl8.TabIndex = 82;
            this.labelControl8.Text = "Supplier No.";
            // 
            // suppliernameTE
            // 
            this.suppliernameTE.Location = new System.Drawing.Point(134, 268);
            this.suppliernameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppliernameTE.Name = "suppliernameTE";
            this.suppliernameTE.Properties.AutoHeight = false;
            this.suppliernameTE.Size = new System.Drawing.Size(148, 21);
            this.suppliernameTE.TabIndex = 86;
            // 
            // suppliernoTE
            // 
            this.suppliernoTE.Location = new System.Drawing.Point(134, 305);
            this.suppliernoTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppliernoTE.Name = "suppliernoTE";
            this.suppliernoTE.Properties.AutoHeight = false;
            this.suppliernoTE.Size = new System.Drawing.Size(148, 21);
            this.suppliernoTE.TabIndex = 87;
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
            this.clearBTN.Location = new System.Drawing.Point(258, 497);
            this.clearBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(37, 33);
            this.clearBTN.TabIndex = 78;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
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
            this.sidePanel2.Location = new System.Drawing.Point(0, 92);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(309, 558);
            this.sidePanel2.TabIndex = 30;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel4
            // 
            this.sidePanel4.AllowResize = false;
            this.sidePanel4.BorderThickness = 0;
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel4.Location = new System.Drawing.Point(0, 0);
            this.sidePanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(927, 41);
            this.sidePanel4.TabIndex = 0;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // sidePanel5
            // 
            this.sidePanel5.AllowResize = false;
            this.sidePanel5.BorderThickness = 0;
            this.sidePanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel5.Location = new System.Drawing.Point(0, 535);
            this.sidePanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel5.Name = "sidePanel5";
            this.sidePanel5.Size = new System.Drawing.Size(927, 23);
            this.sidePanel5.TabIndex = 1;
            this.sidePanel5.Text = "sidePanel5";
            // 
            // sidePanel6
            // 
            this.sidePanel6.AllowResize = false;
            this.sidePanel6.BorderThickness = 0;
            this.sidePanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel6.Location = new System.Drawing.Point(0, 41);
            this.sidePanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel6.Name = "sidePanel6";
            this.sidePanel6.Size = new System.Drawing.Size(16, 494);
            this.sidePanel6.TabIndex = 2;
            this.sidePanel6.Text = "sidePanel6";
            // 
            // sidePanel7
            // 
            this.sidePanel7.AllowResize = false;
            this.sidePanel7.BorderThickness = 0;
            this.sidePanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel7.Location = new System.Drawing.Point(911, 41);
            this.sidePanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel7.Name = "sidePanel7";
            this.sidePanel7.Size = new System.Drawing.Size(16, 494);
            this.sidePanel7.TabIndex = 3;
            this.sidePanel7.Text = "sidePanel7";
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.gcProducts);
            this.sidePanel3.Controls.Add(this.sidePanel7);
            this.sidePanel3.Controls.Add(this.sidePanel6);
            this.sidePanel3.Controls.Add(this.sidePanel5);
            this.sidePanel3.Controls.Add(this.sidePanel4);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(309, 92);
            this.sidePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(927, 558);
            this.sidePanel3.TabIndex = 31;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // gcProducts
            // 
            this.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProducts.Location = new System.Drawing.Point(16, 41);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(895, 494);
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
            this.gvProducts.DetailHeight = 284;
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsEditForm.PopupEditFormWidth = 686;
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
            this.ProductID.MinWidth = 21;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.OptionsColumn.AllowFocus = false;
            this.ProductID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            this.ProductID.Width = 110;
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
            this.ProductName.MinWidth = 21;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.OptionsColumn.AllowFocus = false;
            this.ProductName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 172;
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
            this.CategoryName.MinWidth = 21;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.AllowEdit = false;
            this.CategoryName.OptionsColumn.AllowFocus = false;
            this.CategoryName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 2;
            this.CategoryName.Width = 121;
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
            this.StockQuantity.MinWidth = 21;
            this.StockQuantity.Name = "StockQuantity";
            this.StockQuantity.OptionsColumn.AllowEdit = false;
            this.StockQuantity.OptionsColumn.AllowFocus = false;
            this.StockQuantity.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StockQuantity.Visible = true;
            this.StockQuantity.VisibleIndex = 4;
            this.StockQuantity.Width = 94;
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
            this.StockStatus.MinWidth = 21;
            this.StockStatus.Name = "StockStatus";
            this.StockStatus.OptionsColumn.AllowEdit = false;
            this.StockStatus.OptionsColumn.AllowFocus = false;
            this.StockStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StockStatus.Visible = true;
            this.StockStatus.VisibleIndex = 5;
            this.StockStatus.Width = 139;
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
            this.LocationID.MinWidth = 21;
            this.LocationID.Name = "LocationID";
            this.LocationID.OptionsColumn.AllowEdit = false;
            this.LocationID.OptionsColumn.AllowFocus = false;
            this.LocationID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LocationID.Visible = true;
            this.LocationID.VisibleIndex = 3;
            this.LocationID.Width = 89;
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
            this.ProductPrice.MinWidth = 21;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.OptionsColumn.AllowEdit = false;
            this.ProductPrice.OptionsColumn.AllowFocus = false;
            this.ProductPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ProductPrice.Visible = true;
            this.ProductPrice.VisibleIndex = 6;
            this.ProductPrice.Width = 130;
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
            this.SupplierName.MinWidth = 21;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.OptionsColumn.AllowEdit = false;
            this.SupplierName.OptionsColumn.AllowFocus = false;
            this.SupplierName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SupplierName.Visible = true;
            this.SupplierName.VisibleIndex = 7;
            this.SupplierName.Width = 135;
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
            this.SupplierNo.MinWidth = 21;
            this.SupplierNo.Name = "SupplierNo";
            this.SupplierNo.OptionsColumn.AllowEdit = false;
            this.SupplierNo.OptionsColumn.AllowFocus = false;
            this.SupplierNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.SupplierNo.Visible = true;
            this.SupplierNo.VisibleIndex = 8;
            this.SupplierNo.Width = 153;
            // 
            // LowStockLevel
            // 
            this.LowStockLevel.Caption = "LowStockLevel";
            this.LowStockLevel.FieldName = "LowStockLevel";
            this.LowStockLevel.MinWidth = 21;
            this.LowStockLevel.Name = "LowStockLevel";
            this.LowStockLevel.Width = 81;
            // 
            // InventoryForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryForm";
            this.Size = new System.Drawing.Size(1236, 650);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstocklevelTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productpriceTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aisleLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containerLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productidTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliernoTE.Properties)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            this.sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.LookUpEdit producttypeLUE;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit productnameTE;
        private DevExpress.XtraEditors.TextEdit stocksTE;
        private DevExpress.XtraEditors.TextEdit lowstocklevelTE;
        private DevExpress.XtraEditors.TextEdit productpriceTE;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit aisleLUE;
        private DevExpress.XtraEditors.LookUpEdit containerLUE;
        private DevExpress.XtraEditors.LookUpEdit shelfLUE;
        private DevExpress.XtraEditors.SimpleButton addBTN;
        private DevExpress.XtraEditors.SimpleButton updateBTN;
        private DevExpress.XtraEditors.SimpleButton deleteBTN;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        public DevExpress.XtraEditors.TextEdit productidTE;
        private DevExpress.XtraEditors.SimpleButton producttypeaddBTN;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit suppliernameTE;
        private DevExpress.XtraEditors.TextEdit suppliernoTE;
        private DevExpress.XtraEditors.SimpleButton clearBTN;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn StockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn StockStatus;
        private DevExpress.XtraGrid.Columns.GridColumn LocationID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierNo;
        private DevExpress.XtraGrid.Columns.GridColumn LowStockLevel;
    }
}
