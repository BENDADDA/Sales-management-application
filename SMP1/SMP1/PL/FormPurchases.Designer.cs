namespace smp.PL
{
    partial class FormPurchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchases));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.DataSource = typeof(SMP1.TB_PUR);
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Purchase Name";
            this.gridColumn1.FieldName = "Pur_Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Type";
            this.gridColumn2.FieldName = "Pur_Type";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Category";
            this.gridColumn3.FieldName = "Pur_Cat";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Supplier";
            this.gridColumn4.FieldName = "Pur_Supp";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Details";
            this.gridColumn5.FieldName = "Pur_Det";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Purchase price";
            this.gridColumn6.FieldName = "Pur_Buy";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Sell price";
            this.gridColumn7.FieldName = "Pur_Sell";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Quantity";
            this.gridColumn8.FieldName = "Pur_Qt";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Total purchase price";
            this.gridColumn9.FieldName = "Pur_Tbuy";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Total sell price";
            this.gridColumn10.FieldName = "Pur_Tsell";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Total porfit";
            this.gridColumn11.FieldName = "Pur_TRev";
            this.gridColumn11.FieldNameSortGroup = "Total profit";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
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
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Details";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(287, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(63, 17);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.Text = "Supplier";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(188, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 17);
            this.radioButton6.TabIndex = 8;
            this.radioButton6.Text = "Category";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.callrch);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Type";
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
            // FormPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPurchases";
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
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
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;

    }
}