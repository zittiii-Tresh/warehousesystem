namespace warehousesystem.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RecordNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Position = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel7 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel6 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel5 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.clearBTN = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBTN = new DevExpress.XtraEditors.SimpleButton();
            this.updateBTN = new DevExpress.XtraEditors.SimpleButton();
            this.addBTN = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.middlenameTE = new DevExpress.XtraEditors.TextEdit();
            this.passwordTE = new DevExpress.XtraEditors.TextEdit();
            this.contactnoTE = new DevExpress.XtraEditors.TextEdit();
            this.nameextensionTE = new DevExpress.XtraEditors.TextEdit();
            this.lastnameTE = new DevExpress.XtraEditors.TextEdit();
            this.firstnameTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.positionRG = new DevExpress.XtraEditors.RadioGroup();
            this.statusRG = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel9 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel8 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlenameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactnoTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameextensionTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameTE.Properties)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionRG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusRG.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.gcEmployee);
            this.sidePanel3.Controls.Add(this.sidePanel7);
            this.sidePanel3.Controls.Add(this.sidePanel6);
            this.sidePanel3.Controls.Add(this.sidePanel5);
            this.sidePanel3.Controls.Add(this.sidePanel4);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel3.Location = new System.Drawing.Point(309, 92);
            this.sidePanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(927, 558);
            this.sidePanel3.TabIndex = 34;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // gcEmployee
            // 
            this.gcEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcEmployee.Location = new System.Drawing.Point(16, 41);
            this.gcEmployee.MainView = this.gvEmployee;
            this.gcEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.Size = new System.Drawing.Size(895, 494);
            this.gcEmployee.TabIndex = 4;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // gvEmployee
            // 
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RecordNumber,
            this.EmployeeID,
            this.Position,
            this.EmployeeName,
            this.ContactNo,
            this.EmployeeStatus,
            this.Password});
            this.gvEmployee.DetailHeight = 284;
            this.gvEmployee.GridControl = this.gcEmployee;
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsEditForm.PopupEditFormWidth = 686;
            this.gvEmployee.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvEmployee_RowClick);
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
            this.EmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.EmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.EmployeeID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.MinWidth = 21;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.OptionsColumn.AllowEdit = false;
            this.EmployeeID.OptionsColumn.AllowFocus = false;
            this.EmployeeID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 1;
            this.EmployeeID.Width = 170;
            // 
            // Position
            // 
            this.Position.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Position.AppearanceCell.Options.UseFont = true;
            this.Position.AppearanceCell.Options.UseForeColor = true;
            this.Position.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.Position.AppearanceHeader.Options.UseFont = true;
            this.Position.AppearanceHeader.Options.UseForeColor = true;
            this.Position.Caption = "Position";
            this.Position.FieldName = "PositionID";
            this.Position.MinWidth = 21;
            this.Position.Name = "Position";
            this.Position.OptionsColumn.AllowEdit = false;
            this.Position.OptionsColumn.AllowFocus = false;
            this.Position.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Position.Visible = true;
            this.Position.VisibleIndex = 2;
            this.Position.Width = 168;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmployeeName.AppearanceCell.Options.UseFont = true;
            this.EmployeeName.AppearanceCell.Options.UseForeColor = true;
            this.EmployeeName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.EmployeeName.AppearanceHeader.Options.UseFont = true;
            this.EmployeeName.AppearanceHeader.Options.UseForeColor = true;
            this.EmployeeName.Caption = "Employee Name";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.MinWidth = 21;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.OptionsColumn.AllowEdit = false;
            this.EmployeeName.OptionsColumn.AllowFocus = false;
            this.EmployeeName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 3;
            this.EmployeeName.Width = 357;
            // 
            // ContactNo
            // 
            this.ContactNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ContactNo.AppearanceCell.Options.UseFont = true;
            this.ContactNo.AppearanceCell.Options.UseForeColor = true;
            this.ContactNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.ContactNo.AppearanceHeader.Options.UseFont = true;
            this.ContactNo.AppearanceHeader.Options.UseForeColor = true;
            this.ContactNo.Caption = "Contact No.";
            this.ContactNo.FieldName = "ContactNo";
            this.ContactNo.MinWidth = 21;
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.OptionsColumn.AllowEdit = false;
            this.ContactNo.OptionsColumn.AllowFocus = false;
            this.ContactNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ContactNo.Visible = true;
            this.ContactNo.VisibleIndex = 4;
            this.ContactNo.Width = 297;
            // 
            // EmployeeStatus
            // 
            this.EmployeeStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeStatus.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmployeeStatus.AppearanceCell.Options.UseFont = true;
            this.EmployeeStatus.AppearanceCell.Options.UseForeColor = true;
            this.EmployeeStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeStatus.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(128)))), ((int)(((byte)(51)))));
            this.EmployeeStatus.AppearanceHeader.Options.UseFont = true;
            this.EmployeeStatus.AppearanceHeader.Options.UseForeColor = true;
            this.EmployeeStatus.Caption = "Employee Status";
            this.EmployeeStatus.FieldName = "EmployeeStatus";
            this.EmployeeStatus.MinWidth = 21;
            this.EmployeeStatus.Name = "EmployeeStatus";
            this.EmployeeStatus.OptionsColumn.AllowEdit = false;
            this.EmployeeStatus.OptionsColumn.AllowFocus = false;
            this.EmployeeStatus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.EmployeeStatus.Visible = true;
            this.EmployeeStatus.VisibleIndex = 5;
            this.EmployeeStatus.Width = 157;
            // 
            // Password
            // 
            this.Password.Caption = "Password";
            this.Password.FieldName = "Password";
            this.Password.MinWidth = 21;
            this.Password.Name = "Password";
            this.Password.Width = 81;
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
            // clearBTN
            // 
            this.clearBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.clearBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.clearBTN.Appearance.Options.UseBackColor = true;
            this.clearBTN.Appearance.Options.UseBorderColor = true;
            this.clearBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearBTN.ImageOptions.Image")));
            this.clearBTN.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.clearBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(33, 33);
            this.clearBTN.Location = new System.Drawing.Point(257, 414);
            this.clearBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(37, 33);
            this.clearBTN.TabIndex = 78;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.deleteBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.deleteBTN.Appearance.Options.UseBackColor = true;
            this.deleteBTN.Appearance.Options.UseBorderColor = true;
            this.deleteBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.ImageOptions.Image")));
            this.deleteBTN.Location = new System.Drawing.Point(181, 415);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.deleteBTN.Size = new System.Drawing.Size(76, 32);
            this.deleteBTN.TabIndex = 77;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.updateBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.updateBTN.Appearance.Options.UseBackColor = true;
            this.updateBTN.Appearance.Options.UseBorderColor = true;
            this.updateBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateBTN.ImageOptions.Image")));
            this.updateBTN.Location = new System.Drawing.Point(103, 415);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(76, 32);
            this.updateBTN.TabIndex = 76;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.addBTN.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.addBTN.Appearance.Options.UseBackColor = true;
            this.addBTN.Appearance.Options.UseBorderColor = true;
            this.addBTN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.ImageOptions.Image")));
            this.addBTN.Location = new System.Drawing.Point(23, 415);
            this.addBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(77, 32);
            this.addBTN.TabIndex = 69;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(31, 270);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 15);
            this.labelControl9.TabIndex = 68;
            this.labelControl9.Text = "Position";
            // 
            // middlenameTE
            // 
            this.middlenameTE.Location = new System.Drawing.Point(134, 82);
            this.middlenameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middlenameTE.Name = "middlenameTE";
            this.middlenameTE.Properties.AutoHeight = false;
            this.middlenameTE.Size = new System.Drawing.Size(148, 21);
            this.middlenameTE.TabIndex = 62;
            // 
            // passwordTE
            // 
            this.passwordTE.Location = new System.Drawing.Point(134, 230);
            this.passwordTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTE.Name = "passwordTE";
            this.passwordTE.Properties.AutoHeight = false;
            this.passwordTE.Properties.PasswordChar = '●';
            this.passwordTE.Properties.UseSystemPasswordChar = true;
            this.passwordTE.Size = new System.Drawing.Size(148, 21);
            this.passwordTE.TabIndex = 66;
            // 
            // contactnoTE
            // 
            this.contactnoTE.Location = new System.Drawing.Point(134, 193);
            this.contactnoTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactnoTE.Name = "contactnoTE";
            this.contactnoTE.Properties.AutoHeight = false;
            this.contactnoTE.Size = new System.Drawing.Size(148, 21);
            this.contactnoTE.TabIndex = 65;
            // 
            // nameextensionTE
            // 
            this.nameextensionTE.Location = new System.Drawing.Point(134, 155);
            this.nameextensionTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameextensionTE.Name = "nameextensionTE";
            this.nameextensionTE.Properties.AutoHeight = false;
            this.nameextensionTE.Size = new System.Drawing.Size(148, 21);
            this.nameextensionTE.TabIndex = 64;
            // 
            // lastnameTE
            // 
            this.lastnameTE.Location = new System.Drawing.Point(134, 119);
            this.lastnameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastnameTE.Name = "lastnameTE";
            this.lastnameTE.Properties.AutoHeight = false;
            this.lastnameTE.Size = new System.Drawing.Size(148, 21);
            this.lastnameTE.TabIndex = 63;
            // 
            // firstnameTE
            // 
            this.firstnameTE.Location = new System.Drawing.Point(134, 44);
            this.firstnameTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstnameTE.Name = "firstnameTE";
            this.firstnameTE.Properties.AutoHeight = false;
            this.firstnameTE.Size = new System.Drawing.Size(148, 21);
            this.firstnameTE.TabIndex = 61;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(30, 234);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 59;
            this.labelControl7.Text = "Password:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(30, 197);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 58;
            this.labelControl6.Text = "Contact No.";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(30, 159);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 13);
            this.labelControl5.TabIndex = 57;
            this.labelControl5.Text = "Name Extension:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 123);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "Last Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 85);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 55;
            this.labelControl3.Text = "Middle Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(30, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "First Name:";
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.BorderThickness = 0;
            this.sidePanel2.Controls.Add(this.labelControl8);
            this.sidePanel2.Controls.Add(this.clearBTN);
            this.sidePanel2.Controls.Add(this.deleteBTN);
            this.sidePanel2.Controls.Add(this.updateBTN);
            this.sidePanel2.Controls.Add(this.addBTN);
            this.sidePanel2.Controls.Add(this.labelControl9);
            this.sidePanel2.Controls.Add(this.middlenameTE);
            this.sidePanel2.Controls.Add(this.passwordTE);
            this.sidePanel2.Controls.Add(this.contactnoTE);
            this.sidePanel2.Controls.Add(this.nameextensionTE);
            this.sidePanel2.Controls.Add(this.lastnameTE);
            this.sidePanel2.Controls.Add(this.firstnameTE);
            this.sidePanel2.Controls.Add(this.labelControl7);
            this.sidePanel2.Controls.Add(this.labelControl6);
            this.sidePanel2.Controls.Add(this.labelControl5);
            this.sidePanel2.Controls.Add(this.labelControl4);
            this.sidePanel2.Controls.Add(this.labelControl3);
            this.sidePanel2.Controls.Add(this.labelControl2);
            this.sidePanel2.Controls.Add(this.positionRG);
            this.sidePanel2.Controls.Add(this.statusRG);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel2.Location = new System.Drawing.Point(0, 92);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(309, 558);
            this.sidePanel2.TabIndex = 33;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(30, 343);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(108, 15);
            this.labelControl8.TabIndex = 79;
            this.labelControl8.Text = "Employee Status";
            // 
            // positionRG
            // 
            this.positionRG.Location = new System.Drawing.Point(46, 293);
            this.positionRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.positionRG.Name = "positionRG";
            this.positionRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.positionRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.positionRG.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionRG.Properties.Appearance.Options.UseBackColor = true;
            this.positionRG.Properties.Appearance.Options.UseBorderColor = true;
            this.positionRG.Properties.Appearance.Options.UseFont = true;
            this.positionRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.positionRG.Properties.Columns = 3;
            this.positionRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Admin", true, null, "Admin"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Staff", true, null, "Staff"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cashier", true, null, "Cashier")});
            this.positionRG.Properties.Padding = new System.Windows.Forms.Padding(1);
            this.positionRG.Size = new System.Drawing.Size(234, 33);
            this.positionRG.TabIndex = 67;
            // 
            // statusRG
            // 
            this.statusRG.Location = new System.Drawing.Point(13, 363);
            this.statusRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusRG.Name = "statusRG";
            this.statusRG.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.statusRG.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.statusRG.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusRG.Properties.Appearance.Options.UseBackColor = true;
            this.statusRG.Properties.Appearance.Options.UseBorderColor = true;
            this.statusRG.Properties.Appearance.Options.UseFont = true;
            this.statusRG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.statusRG.Properties.Columns = 2;
            this.statusRG.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Active", true, null, ""),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "In-active", true, null, "")});
            this.statusRG.Properties.Padding = new System.Windows.Forms.Padding(33, 0, 33, 0);
            this.statusRG.Size = new System.Drawing.Size(224, 41);
            this.statusRG.TabIndex = 68;
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
            this.labelControl1.Size = new System.Drawing.Size(238, 53);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Employees";
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
            this.sidePanel1.Size = new System.Drawing.Size(1236, 92);
            this.sidePanel1.TabIndex = 32;
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
            this.dateLabel.Location = new System.Drawing.Point(1155, 26);
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
            this.sidePanel9.Location = new System.Drawing.Point(1212, 26);
            this.sidePanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel9.Name = "sidePanel9";
            this.sidePanel9.Size = new System.Drawing.Size(24, 65);
            this.sidePanel9.TabIndex = 4;
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
            this.sidePanel8.TabIndex = 3;
            this.sidePanel8.Text = "sidePanel8";
            // 
            // EmployeeForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel3);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Size = new System.Drawing.Size(1236, 650);
            this.sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlenameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactnoTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameextensionTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameTE.Properties)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionRG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusRG.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn RecordNumber;
        private DevExpress.XtraEditors.SidePanel sidePanel7;
        private DevExpress.XtraEditors.SidePanel sidePanel6;
        private DevExpress.XtraEditors.SidePanel sidePanel5;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SimpleButton clearBTN;
        private DevExpress.XtraEditors.SimpleButton deleteBTN;
        private DevExpress.XtraEditors.SimpleButton updateBTN;
        private DevExpress.XtraEditors.SimpleButton addBTN;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit middlenameTE;
        private DevExpress.XtraEditors.TextEdit passwordTE;
        private DevExpress.XtraEditors.TextEdit contactnoTE;
        private DevExpress.XtraEditors.TextEdit nameextensionTE;
        private DevExpress.XtraEditors.TextEdit lastnameTE;
        private DevExpress.XtraEditors.TextEdit firstnameTE;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.RadioGroup positionRG;
        private DevExpress.XtraEditors.RadioGroup statusRG;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SidePanel sidePanel8;
        private DevExpress.XtraEditors.SidePanel sidePanel9;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraGrid.Columns.GridColumn Position;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn ContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeStatus;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
    }
}
