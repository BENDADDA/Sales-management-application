using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMP1;
using System.IO;
namespace SMP1.PL
{
    public partial class FormStar : Form
    {
        DB_SMPEntities3 db = new DB_SMPEntities3();
        TBUSER tb = new TBUSER();
        smp.Main main;
        PL.Signin  sin=new PL.Signin();
        public FormStar()
        {
            InitializeComponent();
        }

        private void FormStar_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb = null;

            if (tb != null)
            {
                main = new smp.Main();
                main.label1.Text = tb.Username;
                main.label2.Text = tb.Rol;
                main.pictureBox1.Image = Image.FromStream(new MemoryStream(tb.Image));
                main.Show();

            }
            else
            {

                sin.Show();
            
            }
            this.Hide();
            timer1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
