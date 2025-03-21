namespace warehousesystem.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.loginSP = new DevExpress.XtraEditors.SidePanel();
            this.btnBackToLogin = new DevExpress.XtraEditors.SimpleButton();
            this.textEditEmployeeID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonSignUp = new DevExpress.XtraEditors.SimpleButton();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textEditConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.loginSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loginSP
            // 
            this.loginSP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loginSP.Appearance.Options.UseBackColor = true;
            this.loginSP.Appearance.Options.UseBorderColor = true;
            this.loginSP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginSP.BackgroundImage")));
            this.loginSP.Controls.Add(this.textEditConfirmPassword);
            this.loginSP.Controls.Add(this.labelControl7);
            this.loginSP.Controls.Add(this.btnBackToLogin);
            this.loginSP.Controls.Add(this.textEditEmployeeID);
            this.loginSP.Controls.Add(this.labelControl6);
            this.loginSP.Controls.Add(this.simpleButtonSignUp);
            this.loginSP.Controls.Add(this.textEditPassword);
            this.loginSP.Controls.Add(this.textEditUsername);
            this.loginSP.Controls.Add(this.labelControl5);
            this.loginSP.Controls.Add(this.labelControl4);
            this.loginSP.Controls.Add(this.labelControl3);
            this.loginSP.Location = new System.Drawing.Point(352, 261);
            this.loginSP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.loginSP.Name = "loginSP";
            this.loginSP.Size = new System.Drawing.Size(434, 410);
            this.loginSP.TabIndex = 28;
            this.loginSP.Text = "sidePanel2";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnBackToLogin.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnBackToLogin.Location = new System.Drawing.Point(57, 349);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnBackToLogin.Size = new System.Drawing.Size(31, 33);
            this.btnBackToLogin.TabIndex = 29;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // textEditEmployeeID
            // 
            this.textEditEmployeeID.Location = new System.Drawing.Point(37, 94);
            this.textEditEmployeeID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEditEmployeeID.Name = "textEditEmployeeID";
            this.textEditEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.textEditEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.textEditEmployeeID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditEmployeeID.Size = new System.Drawing.Size(358, 34);
            this.textEditEmployeeID.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 71);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 17);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Employee ID";
            // 
            // simpleButtonSignUp
            // 
            this.simpleButtonSignUp.Appearance.BackColor = System.Drawing.Color.Green;
            this.simpleButtonSignUp.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButtonSignUp.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonSignUp.Appearance.Options.UseBackColor = true;
            this.simpleButtonSignUp.Appearance.Options.UseBorderColor = true;
            this.simpleButtonSignUp.Appearance.Options.UseFont = true;
            this.simpleButtonSignUp.AppearanceDisabled.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButtonSignUp.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButtonSignUp.Location = new System.Drawing.Point(94, 347);
            this.simpleButtonSignUp.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.simpleButtonSignUp.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.simpleButtonSignUp.LookAndFeel.SkinName = "WXI";
            this.simpleButtonSignUp.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonSignUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.simpleButtonSignUp.Name = "simpleButtonSignUp";
            this.simpleButtonSignUp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButtonSignUp.Size = new System.Drawing.Size(262, 38);
            this.simpleButtonSignUp.TabIndex = 8;
            this.simpleButtonSignUp.Text = "Sign Up";
            this.simpleButtonSignUp.Click += new System.EventHandler(this.simpleButtonSignUp_Click);
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(38, 229);
            this.textEditPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.textEditPassword.Properties.Appearance.Options.UseBackColor = true;
            this.textEditPassword.Size = new System.Drawing.Size(356, 34);
            this.textEditPassword.TabIndex = 4;
            // 
            // textEditUsername
            // 
            this.textEditUsername.Location = new System.Drawing.Point(37, 162);
            this.textEditUsername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.textEditUsername.Properties.Appearance.Options.UseBackColor = true;
            this.textEditUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditUsername.Size = new System.Drawing.Size(358, 34);
            this.textEditUsername.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 210);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 17);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Password";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(38, 141);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 17);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Username";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(139, 14);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(156, 50);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "REGISTER";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidePanel1.BackgroundImage")));
            this.sidePanel1.Location = new System.Drawing.Point(272, 105);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(126, 116);
            this.sidePanel1.TabIndex = 27;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(677, 121);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(189, 81);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "System";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(413, 121);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(249, 81);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Inventory";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton3.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton3.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton3.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.simpleButton3.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton3.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(2, 729);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(50, 46);
            this.simpleButton3.TabIndex = 24;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // textEditConfirmPassword
            // 
            this.textEditConfirmPassword.Location = new System.Drawing.Point(37, 294);
            this.textEditConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEditConfirmPassword.Name = "textEditConfirmPassword";
            this.textEditConfirmPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.textEditConfirmPassword.Properties.Appearance.Options.UseBackColor = true;
            this.textEditConfirmPassword.Size = new System.Drawing.Size(356, 34);
            this.textEditConfirmPassword.TabIndex = 31;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(37, 272);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(106, 17);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Confirm Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 775);
            this.Controls.Add(this.loginSP);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton3);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.loginSP.ResumeLayout(false);
            this.loginSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel loginSP;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSignUp;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnBackToLogin;
        private DevExpress.XtraEditors.TextEdit textEditEmployeeID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditConfirmPassword;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}