using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMP1;
namespace smp.PL
{
    public partial class FormHome : Form
    {
        DB_SMPEntities3 db = new DB_SMPEntities3();
        public FormHome()
        {
            InitializeComponent();
            f300();
            
        }

        public void f300()
        {
         
        }
        private void simpleButton22_Click(object sender, EventArgs e)
        {
            SMP1.PL.FRM_CAT_ADD op = new SMP1.PL.FRM_CAT_ADD();
            op.id = 0;
            op.Text = "ADD";
            op.btn_add.Text = "Add";
            op.ShowDialog();
            f300();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SMP1.PL.FRM_PUR frm = new SMP1.PL.FRM_PUR();
            frm.id = 1;
            frm.simpleButton1.Text = "Add";
            frm.Text = "Add";
            frm.ShowDialog();
            f300();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            SMP1.PL.FRM_SUP formadd = new SMP1.PL.FRM_SUP();
            formadd.id = 1;
            formadd.btn_add.Text = "Add";
            formadd.Text = "ADD";
            formadd.ShowDialog();
            f300();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SMP1.PL.FRM_CUS formadd = new SMP1.PL.FRM_CUS();
            formadd.id = 1;
            formadd.btn_add.Text = "Add";
            formadd.Text = "ADD";
            formadd.ShowDialog();
            f300();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SMP1.PL.FRM_SAL frm = new SMP1.PL.FRM_SAL();
            frm.id = 1;
            frm.simpleButton1.Text = "Add";
            frm.Text = "Add";
            frm.ShowDialog();
            f300();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void FormHome_Activated(object sender, EventArgs e)
        {
          
        }
    }
}
