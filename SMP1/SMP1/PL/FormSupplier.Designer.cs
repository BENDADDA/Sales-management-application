namespace smp.PL
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colSup_Name = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSup_Name = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSup_Phone = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSup_Phone = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSup_Email = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSup_Email = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSup_Image = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSup_Image = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton22 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 640);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SMP1.TB_SUP);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1012, 541);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutView1.Appearance.FieldValue.Options.UseFont = true;
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colSup_Name,
            this.colSup_Phone,
            this.colSup_Email,
            this.colSup_Image});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colSup_Name
            // 
            this.colSup_Name.FieldName = "Sup_Name";
            this.colSup_Name.LayoutViewField = this.layoutViewField_colSup_Name;
            this.colSup_Name.Name = "colSup_Name";
            // 
            // layoutViewField_colSup_Name
            // 
            this.layoutViewField_colSup_Name.EditorPreferredWidth = 140;
            this.layoutViewField_colSup_Name.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colSup_Name.Name = "layoutViewField_colSup_Name";
            this.layoutViewField_colSup_Name.Size = new System.Drawing.Size(205, 24);
            this.layoutViewField_colSup_Name.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colSup_Phone
            // 
            this.colSup_Phone.FieldName = "Sup_Phone";
            this.colSup_Phone.LayoutViewField = this.layoutViewField_colSup_Phone;
            this.colSup_Phone.Name = "colSup_Phone";
            // 
            // layoutViewField_colSup_Phone
            // 
            this.layoutViewField_colSup_Phone.EditorPreferredWidth = 137;
            this.layoutViewField_colSup_Phone.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colSup_Phone.Name = "layoutViewField_colSup_Phone";
            this.layoutViewField_colSup_Phone.Size = new System.Drawing.Size(205, 24);
            this.layoutViewField_colSup_Phone.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colSup_Email
            // 
            this.colSup_Email.FieldName = "Sup_Email";
            this.colSup_Email.LayoutViewField = this.layoutViewField_colSup_Email;
            this.colSup_Email.Name = "colSup_Email";
            // 
            // layoutViewField_colSup_Email
            // 
            this.layoutViewField_colSup_Email.EditorPreferredWidth = 137;
            this.layoutViewField_colSup_Email.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colSup_Email.Name = "layoutViewField_colSup_Email";
            this.layoutViewField_colSup_Email.Size = new System.Drawing.Size(205, 24);
            this.layoutViewField_colSup_Email.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colSup_Image
            // 
            this.colSup_Image.FieldName = "Sup_Image";
            this.colSup_Image.LayoutViewField = this.layoutViewField_colSup_Image;
            this.colSup_Image.Name = "colSup_Image";
            // 
            // layoutViewField_colSup_Image
            // 
            this.layoutViewField_colSup_Image.EditorPreferredWidth = 137;
            this.layoutViewField_colSup_Image.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colSup_Image.Name = "layoutViewField_colSup_Image";
            this.layoutViewField_colSup_Image.Size = new System.Drawing.Size(205, 24);
            this.layoutViewField_colSup_Image.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colSup_Name,
            this.layoutViewField_colSup_Phone,
            this.layoutViewField_colSup_Email,
            this.layoutViewField_colSup_Image});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.simpleButton22);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 97);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(467, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(211, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Email";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(115, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Phone";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.AppearanceDisabled.FontSizeDelta = 5;
            this.simpleButton4.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton4.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton4.AppearanceHovered.BackColor = System.Drawing.Color.Maroon;
            this.simpleButton4.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.simpleButton4.AppearanceHovered.BorderColor = System.Drawing.Color.Maroon;
            this.simpleButton4.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton4.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton4.AppearancePressed.BackColor = System.Drawing.Color.Maroon;
            this.simpleButton4.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton4.AppearancePressed.BorderColor = System.Drawing.Color.Maroon;
            this.simpleButton4.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton4.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(478, 45);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(34, 27);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Visible = false;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton5.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseBorderColor = true;
            this.simpleButton5.AppearanceDisabled.FontSizeDelta = 5;
            this.simpleButton5.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton5.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton5.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton5.AppearanceHovered.BackColor2 = System.Drawing.Color.GreenYellow;
            this.simpleButton5.AppearanceHovered.BorderColor = System.Drawing.Color.Lime;
            this.simpleButton5.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton5.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton5.AppearancePressed.BackColor = System.Drawing.Color.Green;
            this.simpleButton5.AppearancePressed.BackColor2 = System.Drawing.Color.DarkGreen;
            this.simpleButton5.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton5.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton5.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(477, 45);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(34, 27);
            this.simpleButton5.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.YellowGreen;
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.AppearancePressed.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.simpleButton3.AppearancePressed.BackColor2 = System.Drawing.Color.DarkGreen;
            this.simpleButton3.AppearancePressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.simpleButton3.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton3.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(358, 21);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(103, 58);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Update";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.YellowGreen;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.simpleButton2.AppearancePressed.BackColor2 = System.Drawing.Color.DarkGreen;
            this.simpleButton2.AppearancePressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(249, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 58);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Delete";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.YellowGreen;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.simpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.DarkGreen;
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(140, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 58);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Edit";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton22
            // 
            this.simpleButton22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton22.Appearance.BackColor2 = System.Drawing.Color.YellowGreen;
            this.simpleButton22.Appearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.simpleButton22.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton22.Appearance.Options.UseBackColor = true;
            this.simpleButton22.Appearance.Options.UseBorderColor = true;
            this.simpleButton22.Appearance.Options.UseFont = true;
            this.simpleButton22.AppearancePressed.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.simpleButton22.AppearancePressed.BackColor2 = System.Drawing.Color.DarkGreen;
            this.simpleButton22.AppearancePressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.simpleButton22.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton22.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton22.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton22.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton22.ImageOptions.Image")));
            this.simpleButton22.Location = new System.Drawing.Point(31, 21);
            this.simpleButton22.Name = "simpleButton22";
            this.simpleButton22.Size = new System.Drawing.Size(103, 58);
            this.simpleButton22.TabIndex = 4;
            this.simpleButton22.Text = "Add";
            this.simpleButton22.Click += new System.EventHandler(this.simpleButton22_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSupplier";
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSup_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton22;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSup_Name;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSup_Name;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSup_Phone;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSup_Phone;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSup_Email;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSup_Email;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSup_Image;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSup_Image;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}