using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMP1.EPL;
using System.Drawing.Imaging;
using System.IO;
namespace SMP1.PL
{

    
    public partial class Signin: Form
    {
        public int key;
        public int id=1;
        smp.Main main;
        public Signin()
        {
            InitializeComponent();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            SMP1.LB.Methods method = new SMP1.LB.Methods();
            DB_SMPEntities3 db = new DB_SMPEntities3();
            TBUSER tb = new TBUSER();
            Toast toast = new Toast();

            // Add or Edit
            if (ebt_name.Text == ""||textBox1.Text=="")
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Please write all informations", "Information", button, MessageBoxIcon.Information);
               
            }
            else
            {
                tb = db.TBUSERs.Where(x => x.Password == textBox1.Text && x.Username == ebt_name.Text).FirstOrDefault();
                
                if (tb != null)
                {
                    main = new smp.Main();

                    string str = tb.Rol;
                    byte[] bit = tb.Image;
                    
                    db.DeleteObject(tb);
                    db.SaveChanges();
                    tb = new TBUSER();
                    tb.stt = "True";
                    tb.Password = textBox1.Text;
                    tb.Username = ebt_name.Text;
                    tb.Rol = str;
                    tb.Image = bit;
                    db = new DB_SMPEntities3();
                    db.TBUSERs.AddObject(tb);
                    db.SaveChanges();
                    main.label1.Text = tb.Username;
                    main.label2.Text = str;
                    main.pictureBox1.Image = Image.FromStream(new MemoryStream(bit));
                    main.Enabled = true;
                    main.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Faild Login" , "Information");
                    
                }
            }
            
           
         
                    
                    
                   
   
          
            
        }

        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {
            
        }

        private void ebt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FRM_USE_Activated(object sender, EventArgs e)
        {
            
            
        }

        private void Signin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Signin_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
