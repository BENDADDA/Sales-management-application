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

    
    public partial class FRM_SUP : Form
    {
        public int key;
        public int id=1;
        public FRM_SUP()
        {
            InitializeComponent();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            SMP1.LB.Methods method = new SMP1.LB.Methods();
            DB_SMPEntities3 db = new DB_SMPEntities3();
            TB_SUP tb = new TB_SUP();
            Toast toast = new Toast();

            // Add or Edit
            if (ebt_name.Text == ""||textBox1.Text==""||textBox2.Text=="")
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
                    tb.Sup_Image = method.ToByte();
                    tb.Sup_Name = ebt_name.Text;
                    tb.Sup_Phone = textBox1.Text;
                    tb.Sup_Email = textBox2.Text;
                    db.TB_SUP.AddObject(tb);
                    db.SaveChanges();
                    toast.label1.Text = "A new supplier is added";
                    toast.timer1.Interval = 2000;
                    toast.Show();
                    Close();
                }//edit
                else
                {
                    try
                    {
                        db=new DB_SMPEntities3();
                        tb = db.TB_SUP.Where(x => x.ID == key).FirstOrDefault();
                        db.TB_SUP.DeleteObject(tb);
                        db.SaveChanges();
                        db = new DB_SMPEntities3();
                        pic_cover.Image.Save(method.mrs, ImageFormat.Png);
                        tb.Sup_Image = method.ToByte();
                        tb.Sup_Name = ebt_name.Text;
                        tb.Sup_Phone = textBox1.Text;
                        tb.Sup_Email = textBox2.Text;
                        db.TB_SUP.AddObject(tb);
                        db.SaveChanges();
                        toast.label1.Text = "A new supplier is edit";
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

      
    }
}
