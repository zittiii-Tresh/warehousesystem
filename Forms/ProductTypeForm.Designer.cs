namespace warehousesystem.Forms
{
    partial class ProductTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTypeForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.categoruGC = new DevExpress.XtraEditors.GroupControl();
            this.categoryTE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.categorysaveBTN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoruGC)).BeginInit();
            this.categoruGC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.ForeColor = System.Drawing.Color.White;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(476, 61);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // categoruGC
            // 
            this.categoruGC.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoruGC.Appearance.Options.UseFont = true;
            this.categoruGC.AppearanceCaption.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoruGC.AppearanceCaption.Options.UseFont = true;
            this.categoruGC.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(5);
            this.categoruGC.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("categoruGC.CaptionImageOptions.SvgImage")));
            this.categoruGC.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.categoruGC.Controls.Add(this.categoryTE);
            this.categoruGC.Controls.Add(this.labelControl1);
            this.categoruGC.Location = new System.Drawing.Point(25, 78);
            this.categoruGC.Name = "categoruGC";
            this.categoruGC.Size = new System.Drawing.Size(424, 121);
            this.categoruGC.TabIndex = 2;
            this.categoruGC.Text = "Category";
            // 
            // categoryTE
            // 
            this.categoryTE.Location = new System.Drawing.Point(122, 60);
            this.categoryTE.MenuManager = this.ribbon;
            this.categoryTE.Name = "categoryTE";
            this.categoryTE.Size = new System.Drawing.Size(279, 34);
            this.categoryTE.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Product Type:";
            // 
            // categorysaveBTN
            // 
            this.categorysaveBTN.Appearance.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorysaveBTN.Appearance.Options.UseFont = true;
            this.categorysaveBTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("categorysaveBTN.ImageOptions.SvgImage")));
            this.categorysaveBTN.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.categorysaveBTN.Location = new System.Drawing.Point(194, 219);
            this.categorysaveBTN.Name = "categorysaveBTN";
            this.categorysaveBTN.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.categorysaveBTN.Size = new System.Drawing.Size(84, 32);
            this.categorysaveBTN.TabIndex = 3;
            this.categorysaveBTN.Text = "SAVE";
            this.categorysaveBTN.Click += new System.EventHandler(this.categorysaveBTN_Click);
            // 
            // ProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 267);
            this.Controls.Add(this.categorysaveBTN);
            this.Controls.Add(this.categoruGC);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ProductTypeForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductTypeForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Type";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoruGC)).EndInit();
            this.categoruGC.ResumeLayout(false);
            this.categoruGC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl categoruGC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit categoryTE;
        private DevExpress.XtraEditors.SimpleButton categorysaveBTN;
    }
}