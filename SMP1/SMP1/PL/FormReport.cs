using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smp.PL
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SMP1.PL.Reports.rcat frm = new SMP1.PL.Reports.rcat();
            frm.documentViewer1.DocumentSource = new SMP1.XtraReport3();
            frm.Show();
        }

        private void bunifuCards3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            SMP1.PL.Reports.rcat frm = new SMP1.PL.Reports.rcat();
            frm.documentViewer1.DocumentSource = new SMP1.XtraReport1();
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SMP1.PL.Reports.rcat frm = new SMP1.PL.Reports.rcat();
            frm.documentViewer1.DocumentSource = new SMP1.XtraReport2();
            frm.Show();
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            SMP1.PL.Reports.rcat frm = new SMP1.PL.Reports.rcat();
            frm.documentViewer1.DocumentSource = new SMP1.XtraReport3();
            frm.Show();
        }

        private void bunifuCards4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            SMP1.PL.Reports.rcat frm = new SMP1.PL.Reports.rcat();
            frm.documentViewer1.DocumentSource = new SMP1.XtraReport5();
            frm.Show();
        }

        private void bunifuCards5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCards6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cswdsd(object sender, EventArgs e)
        {
            SMP1.PL.Reports.rcat frm = new SMP1.PL.Reports.rcat();
            frm.documentViewer1.DocumentSource = new SMP1.XtraReport4();
            frm.Show();
        }
    }
}
