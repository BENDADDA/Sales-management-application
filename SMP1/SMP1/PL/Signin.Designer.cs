namespace SMP1.PL
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.ebt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ebt_name
            // 
            this.ebt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ebt_name.Location = new System.Drawing.Point(12, 220);
            this.ebt_name.Name = "ebt_name";
            this.ebt_name.Size = new System.Drawing.Size(315, 31);
            this.ebt_name.TabIndex = 6;
            this.ebt_name.TextChanged += new System.EventHandler(this.ebt_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(315, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.ebt_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Image";
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
            this.btn_add.Location = new System.Drawing.Point(-3, 349);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(343, 42);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Sign in";
            this.btn_add.Click += new System.EventHandler(this.simpleButton22_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(200, 75);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pic_cover.Properties.Appearance.Options.UseBackColor = true;
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.pic_cover.Properties.ErrorImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pic_cover.Properties.ErrorImageOptions.Image")));
            this.pic_cover.Properties.InitialImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pic_cover.Properties.InitialImageOptions.Image")));
            this.pic_cover.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(124, 145);
            this.pic_cover.TabIndex = 0;
            this.pic_cover.EditValueChanged += new System.EventHandler(this.pic_cover_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(103, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sign in";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.AppearanceDisabled.FontSizeDelta = 5;
            this.simpleButton1.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton1.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.Maroon;
            this.simpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(289, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 36);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 390);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ebt_name);
            this.Controls.Add(this.pic_cover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Signin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_USE_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Signin_FormClosed);
            this.Load += new System.EventHandler(this.FRM_CAT_ADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox ebt_name;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}