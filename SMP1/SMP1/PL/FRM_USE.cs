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
namespace SMP1.PL
{

    
    public partial class FRM_USE: Form
    {
        public int key;
        public int id=1;
        public FRM_USE()
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
            if (ebt_name.Text == ""||textBox1.Text==""||comboBox1.Text=="")
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("Please write all informations", "Information", button, MessageBoxIcon.Information);
               
            }
            else
            {
                //add
                if (id == 1)
                {
                    pic_cover.Image.Save(method.mrs, ImageFormat.Png);
                    tb.Image = method.ToByte();
                    tb.Username = ebt_name.Text;
                    tb.Password = textBox1.Text;
                    tb.Rol = comboBox1.Text;
                    tb.stt = "False";
                    db.TBUSERs.AddObject(tb);
                    db.SaveChanges();
                    toast.label1.Text = "A new user is added";
                    toast.timer1.Interval = 2000;
                    toast.Show();
                    Close();
                }//edit
                else
                {
                    try
                    {
                        db=new DB_SMPEntities3();
                        tb = db.TBUSERs.Where(x => x.ID == key).FirstOrDefault();
                        db.TBUSERs.DeleteObject(tb);
                        db.SaveChanges();
                        db = new DB_SMPEntities3();
                        pic_cover.Image.Save(method.mrs, ImageFormat.Png);
                        tb.Image = method.ToByte();
                        tb.Username = ebt_name.Text;
                        tb.Password = textBox1.Text;
                        tb.Rol = comboBox1.Text;
                        db.TBUSERs.AddObject(tb);
                        tb.stt = "False";
                        db.SaveChanges();
                        toast.label1.Text = "A new user is edit";
                        toast.timer1.Interval = 2000;
                        toast.Show();
                        Close();

                    }
                    catch { }
                
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

      
    }
}
