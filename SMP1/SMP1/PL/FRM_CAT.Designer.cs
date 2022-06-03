namespace SMP1.PL
{
    partial class FRM_CAT_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CAT_ADD));
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.ebt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_cover
            // 
            this.pic_cover.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(117, 144);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(173, 176);
            this.pic_cover.TabIndex = 0;
            this.pic_cover.EditValueChanged += new System.EventHandler(this.pic_cover_EditValueChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add.Appearance.BackColor2 = System.Drawing.Color.YellowGreen;
            this.btn_add.Appearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseBorderColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.AppearancePressed.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_add.AppearancePressed.BackColor2 = System.Drawing.Color.DarkGreen;
            this.btn_add.AppearancePressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.btn_add.AppearancePressed.Options.UseBackColor = true;
            this.btn_add.AppearancePressed.Options.UseBorderColor = true;
            this.btn_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(22, 349);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 58);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.simpleButton22_Click);
            // 
            // ebt_name
            // 
            this.ebt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebt_name.Location = new System.Drawing.Point(63, 74);
            this.ebt_name.Name = "ebt_name";
            this.ebt_name.Size = new System.Drawing.Size(278, 31);
            this.ebt_name.TabIndex = 6;
            this.ebt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ebt_name.TextChanged += new System.EventHandler(this.ebt_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categoty Name";
            // 
            // FRM_CAT_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ebt_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FRM_CAT_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_CAT_ADD_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_CAT_ADD_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox ebt_name;
    }
}