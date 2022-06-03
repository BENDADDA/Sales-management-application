using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DXApplication3.Properties;
using DXApplication3;
using System.Media;
namespace smp
{
    public partial class Main : Form
    {

        int id = 1;
        PL.FormHome obja = new PL.FormHome();
        PL.FormSupplier objc = new PL.FormSupplier();
        public PL.FormCategory objb = new PL.FormCategory();
        PL.FormPurchases objd = new PL.FormPurchases();
        PL.FormCustomer objf = new PL.FormCustomer();
        PL.FormSale obje = new PL.FormSale();
        PL.FormReport objg = new PL.FormReport();
        PL.FormUser obji = new PL.FormUser();
        public Main()
        {
            InitializeComponent();
            new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\Microsoft Windows XP Strtup Sound.wav").Play();
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else
            {
                this.WindowState = FormWindowState.Normal;
                if (fc == 1) this.FormBorderStyle = FormBorderStyle.FixedSingle;
                fc = 0;
            }
        }

     

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            if(id!=1)
            {
                label3.Text="Home";
                panel_cont.Controls.Clear();
                panel_cont.Controls.Add(obja.panel1);
                new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\Windows Logon Sound.wav").Play();
                id = 1;
                obja.f300();
            }
           
           
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dcd(object sender, EventArgs e)
        {
            if (panel_navbar.Size.Width == 250) { panel_navbar.Width = 60; gpanel1.Visible = false; }
            else { panel_navbar.Width = 250; gpanel1.Visible = true; }
        }

        private void ME(object sender, EventArgs e)
        {
         
            
                
        }


        Form1 opj = new Form1();
        private void simpleButton17_Click(object sender, EventArgs e)
        {


            if (opj.deactive == 1);
            else
            {
                opj = new Form1();
                opj.deactive = 1;
                opj.Show();
               
            }
            
           
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {

        }

        private void panel_topbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Clls_Click(object sender, EventArgs e)
        {
            if(id!=2)
            {
                label3.Text = "Class";
            panel_cont.Controls.Clear();
            panel_cont.Controls.Add(objb.panel1);
            SMP1.DB_SMPEntities3 db = new SMP1.DB_SMPEntities3();
            objb.gridControl1.DataSource = db.TB_CAT.ToList();
            new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\Windows Logon Sound~1.wav").Play();
            id = 2;
           
            }
            

        }

        private void LD(object sender, EventArgs e)
        {

            panel_cont.Controls.Add(obja.panel1);
            if (label2.Text == "Administrator")
            {
                simpleButton13.Enabled = true;
            }
            else simpleButton13.Enabled = false;
           
        }
        int fc = 0;
        private void lick(object sender, EventArgs e)
        {
            if (fc == 0)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                fc = 1;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
                fc = 0;
            }
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
          
            PrintDialog ogf = new PrintDialog();
            ogf.ShowDialog();
         
        }

        private void misag(object sender, EventArgs e)
        {
            MessageBoxButtons opj = MessageBoxButtons.OK;
            DialogResult = MessageBox.Show("frezferf", "zedfze",opj,MessageBoxIcon.Information);
            
        }

        private void sqxsq(object sender, EventArgs e)
        {
            if (id != 3)
            {
                label3.Text = "Suppliers";
                panel_cont.Controls.Clear();
                panel_cont.Controls.Add(objc.panel1);
                SMP1.DB_SMPEntities3 db = new SMP1.DB_SMPEntities3();
                objb.gridControl1.DataSource = db.TB_CAT.ToList();
                new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\bb.wav").Play();
                id = 3;
            }
        }

        private void fvdsxs(object sender, EventArgs e)
        {
            if (id == 4) return;
            id = 4;
            panel_cont.Controls.Clear();
            panel_cont.Controls.Add(objd.panel1);
            label3.Text = "Purchases";
            new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\gg.wav").Play();

        }

        private void xqsxsq(object sender, EventArgs e)
        {
            if (id == 5) return;
            id = 5;
            panel_cont.Controls.Clear();
            panel_cont.Controls.Add(obje.panel1);
            label3.Text = "Sales";
             new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\ff.wav").Play();
        }

        private void dscsdc(object sender, EventArgs e)
        {
            if (id == 6) return;
            id = 6;
            label3.Text = "Customers";
            panel_cont.Controls.Clear();
            panel_cont.Controls.Add(objf.panel1);
            new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\cc.wav").Play();
        }

        private void cdsck(object sender, EventArgs e)
        {
            if (id == 7) return;
            id = 7;
            panel_cont.Controls.Clear();
            panel_cont.Controls.Add(objg.panel1);
            label3.Text = "Report";
             new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\ee.wav").Play();
        }

        private void dcsdk(object sender, EventArgs e)
        {
            if (id == 8) return;
            id = 8;
            panel_cont.Controls.Clear();
            panel_cont.Controls.Add(obji.panel1);
            label3.Text = "Users";
             new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\aa.wav").Play();
        }

        private void dscdsc(object sender, EventArgs e)
        {
            if (id == 9) return;
            id = 9;
            label3.Text = "Settings";
            new SoundPlayer(@"C:\Users\HDMI\Documents\Visual Studio 2010\Projects\SMP1\SMP1\Calculator\dscsd.wav").Play();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nghn(object sender, EventArgs e)
        {

        }

        private void njuy(object sender, EventArgs e)
        {
            SMP1.PL.Signin frm = new SMP1.PL.Signin();
            SMP1.DB_SMPEntities3 db = new SMP1.DB_SMPEntities3();
            SMP1.TBUSER tb = new SMP1.TBUSER();

            tb = db.TBUSERs.Where(x => x.stt=="True").FirstOrDefault();
            if(tb==null)tb = db.TBUSERs.Where(x => x.Password ==x.Password && x.Username ==x.Username).FirstOrDefault();


            string rol = tb.Rol,ps=tb.Password,usn=tb.Username;

            byte[] bit=tb.Image;
            db.DeleteObject(tb);
            db.SaveChanges();
            tb = new SMP1.TBUSER();
            tb.stt = "False";
            tb.Password = ps;
            tb.Username = usn;
            tb.Image = bit;
            tb.Rol = rol;
            db = new SMP1.DB_SMPEntities3();
            db.TBUSERs.AddObject(tb);
            db.SaveChanges();
                
              



            frm.Show();
            this.Enabled = false;
            this.Hide();
         
        }

     
    }
}
