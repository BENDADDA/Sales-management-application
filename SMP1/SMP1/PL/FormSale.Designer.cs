namespace smp.PL
{
    partial class FormSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSell_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_TPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPur_Name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Type = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Cat = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Supp = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Det = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Buy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Sell = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Qt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Tbuy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_Tsell = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPur_TRev = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
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
            this.gridControl1.DataSource = typeof(SMP1.TB_SELL);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1012, 541);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.bandedGridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightYellow;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSell_Name,
            this.colSell_Cus,
            this.colSell_Price,
            this.colSell_Qt,
            this.colSell_TPrice,
            this.colSell_Date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            // 
            // colSell_Name
            // 
            this.colSell_Name.Caption = "Material name";
            this.colSell_Name.FieldName = "Sell_Name";
            this.colSell_Name.Name = "colSell_Name";
            this.colSell_Name.Visible = true;
            this.colSell_Name.VisibleIndex = 0;
            // 
            // colSell_Cus
            // 
            this.colSell_Cus.Caption = "Customer";
            this.colSell_Cus.FieldName = "Sell_Cus";
            this.colSell_Cus.Name = "colSell_Cus";
            this.colSell_Cus.Visible = true;
            this.colSell_Cus.VisibleIndex = 1;
            // 
            // colSell_Price
            // 
            this.colSell_Price.Caption = "Sale price";
            this.colSell_Price.FieldName = "Sell_Price";
            this.colSell_Price.Name = "colSell_Price";
            this.colSell_Price.Visible = true;
            this.colSell_Price.VisibleIndex = 2;
            // 
            // colSell_Qt
            // 
            this.colSell_Qt.Caption = "Quantity";
            this.colSell_Qt.FieldName = "Sell_Qt";
            this.colSell_Qt.Name = "colSell_Qt";
            this.colSell_Qt.Visible = true;
            this.colSell_Qt.VisibleIndex = 3;
            // 
            // colSell_TPrice
            // 
            this.colSell_TPrice.Caption = "Total price";
            this.colSell_TPrice.FieldName = "Sell_TPrice";
            this.colSell_TPrice.Name = "colSell_TPrice";
            this.colSell_TPrice.Visible = true;
            this.colSell_TPrice.VisibleIndex = 4;
            // 
            // colSell_Date
            // 
            this.colSell_Date.Caption = "Date";
            this.colSell_Date.FieldName = "Sell_Date";
            this.colSell_Date.Name = "colSell_Date";
            this.colSell_Date.Visible = true;
            this.colSell_Date.VisibleIndex = 5;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.bandedGridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.bandedGridView1.Appearance.FixedLine.Options.UseFont = true;
            this.bandedGridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.bandedGridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightYellow;
            this.bandedGridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.bandedGridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.bandedGridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bandedGridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colPur_Name,
            this.colPur_Type,
            this.colPur_Cat,
            this.colPur_Supp,
            this.colPur_Det,
            this.colPur_Buy,
            this.colPur_Sell,
            this.colPur_Qt,
            this.colPur_Tbuy,
            this.colPur_Tsell,
            this.colPur_TRev});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colPur_Name);
            this.gridBand1.Columns.Add(this.colPur_Type);
            this.gridBand1.Columns.Add(this.colPur_Cat);
            this.gridBand1.Columns.Add(this.colPur_Supp);
            this.gridBand1.Columns.Add(this.colPur_Det);
            this.gridBand1.Columns.Add(this.colPur_Buy);
            this.gridBand1.Columns.Add(this.colPur_Sell);
            this.gridBand1.Columns.Add(this.colPur_Qt);
            this.gridBand1.Columns.Add(this.colPur_Tbuy);
            this.gridBand1.Columns.Add(this.colPur_Tsell);
            this.gridBand1.Columns.Add(this.colPur_TRev);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 825;
            // 
            // colPur_Name
            // 
            this.colPur_Name.Caption = "Purchase Name";
            this.colPur_Name.FieldName = "Pur_Name";
            this.colPur_Name.Name = "colPur_Name";
            this.colPur_Name.Visible = true;
            // 
            // colPur_Type
            // 
            this.colPur_Type.Caption = "Type";
            this.colPur_Type.FieldName = "Pur_Type";
            this.colPur_Type.Name = "colPur_Type";
            this.colPur_Type.Visible = true;
            // 
            // colPur_Cat
            // 
            this.colPur_Cat.Caption = "Category";
            this.colPur_Cat.FieldName = "Pur_Cat";
            this.colPur_Cat.Name = "colPur_Cat";
            this.colPur_Cat.Visible = true;
            // 
            // colPur_Supp
            // 
            this.colPur_Supp.Caption = "Supplier";
            this.colPur_Supp.FieldName = "Pur_Supp";
            this.colPur_Supp.Name = "colPur_Supp";
            this.colPur_Supp.Visible = true;
            // 
            // colPur_Det
            // 
            this.colPur_Det.Caption = "Details";
            this.colPur_Det.FieldName = "Pur_Det";
            this.colPur_Det.Name = "colPur_Det";
            this.colPur_Det.Visible = true;
            // 
            // colPur_Buy
            // 
            this.colPur_Buy.Caption = "Purchase price";
            this.colPur_Buy.FieldName = "Pur_Buy";
            this.colPur_Buy.Name = "colPur_Buy";
            this.colPur_Buy.Visible = true;
            // 
            // colPur_Sell
            // 
            this.colPur_Sell.Caption = "Sell price";
            this.colPur_Sell.FieldName = "Pur_Sell";
            this.colPur_Sell.Name = "colPur_Sell";
            this.colPur_Sell.Visible = true;
            // 
            // colPur_Qt
            // 
            this.colPur_Qt.Caption = "Quantity";
            this.colPur_Qt.FieldName = "Pur_Qt";
            this.colPur_Qt.Name = "colPur_Qt";
            this.colPur_Qt.Visible = true;
            // 
            // colPur_Tbuy
            // 
            this.colPur_Tbuy.Caption = "Total purchase price";
            this.colPur_Tbuy.FieldName = "Pur_Tbuy";
            this.colPur_Tbuy.Name = "colPur_Tbuy";
            this.colPur_Tbuy.Visible = true;
            // 
            // colPur_Tsell
            // 
            this.colPur_Tsell.Caption = "Total sell price";
            this.colPur_Tsell.FieldName = "Pur_Tsell";
            this.colPur_Tsell.Name = "colPur_Tsell";
            this.colPur_Tsell.Visible = true;
            // 
            // colPur_TRev
            // 
            this.colPur_TRev.Caption = "Total porfit";
            this.colPur_TRev.FieldName = "Pur_TRev";
            this.colPur_TRev.FieldNameSortGroup = "Total profit";
            this.colPur_TRev.Name = "colPur_TRev";
            this.colPur_TRev.Visible = true;
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
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
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
            this.radioButton3.Location = new System.Drawing.Point(382, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Total price";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(287, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(64, 17);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.Text = "Quantity";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Visible = false;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(188, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(48, 17);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.Text = "Data";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Visible = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Costomer";
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
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSale";
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Type;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Cat;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Supp;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Det;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Buy;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Sell;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Qt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Tbuy;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_Tsell;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPur_TRev;
        private System.Windows.Forms.RadioButton radioButton6;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Cus;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_TPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Date;
        private System.Windows.Forms.RadioButton radioButton7;

    }
}