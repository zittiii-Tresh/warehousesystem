namespace warehousesystem.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.loginSP = new DevExpress.XtraEditors.SidePanel();
            this.textEditPassword = new DevExpress.XtraEditors.ButtonEdit();
            this.LoginBTN = new DevExpress.XtraEditors.SimpleButton();
            this.textEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.loginSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnExit.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.btnExit.AppearanceDisabled.Options.UseBackColor = true;
            this.btnExit.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.Violet;
            this.btnExit.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.Options.UseBorderColor = true;
            this.btnExit.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearancePressed.Options.UseBackColor = true;
            this.btnExit.AppearancePressed.Options.UseBorderColor = true;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Location = new System.Drawing.Point(12, 574);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnExit.Size = new System.Drawing.Size(43, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "simpleButton3";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // loginSP
            // 
            this.loginSP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loginSP.Appearance.Options.UseBackColor = true;
            this.loginSP.Appearance.Options.UseBorderColor = true;
            this.loginSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginSP.BackgroundImage")));
            this.loginSP.Controls.Add(this.textEditPassword);
            this.loginSP.Controls.Add(this.LoginBTN);
            this.loginSP.Controls.Add(this.textEditUserName);
            this.loginSP.Controls.Add(this.labelControl5);
            this.loginSP.Controls.Add(this.labelControl4);
            this.loginSP.Controls.Add(this.labelControl3);
            this.loginSP.Location = new System.Drawing.Point(302, 193);
            this.loginSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginSP.Name = "loginSP";
            this.loginSP.Size = new System.Drawing.Size(429, 407);
            this.loginSP.TabIndex = 23;
            this.loginSP.Text = "sidePanel2";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(65, 225);
            this.textEditPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditPassword.Name = "textEditPassword";
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.textEditPassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(307, 28);
            this.textEditPassword.TabIndex = 4;
            this.textEditPassword.Tag = "close";
            this.textEditPassword.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.textEditPassword_ButtonPressed);
            this.textEditPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditPassword_KeyDown);
            // 
            // LoginBTN
            // 
            this.LoginBTN.Appearance.BackColor = System.Drawing.Color.Green;
            this.LoginBTN.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.LoginBTN.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.Appearance.Options.UseBackColor = true;
            this.LoginBTN.Appearance.Options.UseBorderColor = true;
            this.LoginBTN.Appearance.Options.UseFont = true;
            this.LoginBTN.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.LoginBTN.AppearanceDisabled.Options.UseBorderColor = true;
            this.LoginBTN.Location = new System.Drawing.Point(106, 300);
            this.LoginBTN.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.LoginBTN.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.LoginBTN.LookAndFeel.SkinName = "WXI";
            this.LoginBTN.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.LoginBTN.Size = new System.Drawing.Size(225, 31);
            this.LoginBTN.TabIndex = 5;
            this.LoginBTN.Text = "Log In";
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // textEditUserName
            // 
            this.textEditUserName.Location = new System.Drawing.Point(65, 156);
            this.textEditUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditUserName.Name = "textEditUserName";
            this.textEditUserName.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.textEditUserName.Properties.Appearance.Options.UseBackColor = true;
            this.textEditUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditUserName.Size = new System.Drawing.Size(307, 28);
            this.textEditUserName.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(66, 205);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 12);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Password:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(66, 138);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 12);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Employee ID:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(174, 67);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 41);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "LOGIN";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel1.BackgroundImage")));
            this.sidePanel1.Location = new System.Drawing.Point(233, 53);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(124, 111);
            this.sidePanel1.TabIndex = 22;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(580, 66);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(151, 65);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "System";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(354, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(199, 65);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Inventory";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "eyeclose.png");
            this.imageCollection1.Images.SetKeyName(1, "eyeopen.png");
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 622);
            this.Controls.Add(this.loginSP);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnExit);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginSP.ResumeLayout(false);
            this.loginSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SidePanel loginSP;
        private DevExpress.XtraEditors.SimpleButton LoginBTN;
        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.ButtonEdit textEditPassword;
    }
}