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

    
    public partial class FRM_CAT_ADD : Form
    {
        
        public int id = 0;
        public int id1;
        public FRM_CAT_ADD()
        {
            InitializeComponent();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
             DB_SMPEntities3 db = new DB_SMPEntities3();
             TB_CAT tb = new TB_CAT();
            
             LB.Methods methods = new LB.Methods();
            if (ebt_name.Text == "")
            {
                MessageBoxButtons mbutton = MessageBoxButtons.OK;
                MessageBox.Show("The category name is required", "Information", mbutton, MessageBoxIcon.Information);

            }
            else
            {
                //add
                if (id == 0)
                {
                   
                    pic_cover.Image.Save(methods.mrs, ImageFormat.Png);
                    tb.CAT_Cover= methods.ToByte();
                    tb.CAT_Name = ebt_name.Text;
                    db.AddToTB_CAT(tb);
                    db.SaveChanges();
                    Toast toast = new Toast();
                    toast.timer1.Interval = 2000;
                    toast.label1.Text = "A new item is added";
                    toast.Show();
                    db = new SMP1.DB_SMPEntities3();
                    this.Close();
                    
                    
                   
                }
                else
                { 
                    
                    //edit
                    tb = db.TB_CAT.Where(x => x.ID == id1).FirstOrDefault();
                  
                    db.TB_CAT.DeleteObject(tb);
                    db.SaveChanges();

                    pic_cover.Image.Save(methods.mrs, ImageFormat.Png);
                    tb.CAT_Cover = methods.ToByte();
                    tb.CAT_Name = ebt_name.Text;
                    db.AddToTB_CAT(tb);
                    db.SaveChanges();
                    
                    Toast toast = new Toast();
                    toast.timer1.Interval = 2000;
                    toast.label1.Text = "The item is edited";
                    toast.Show();
                    this.Close();
                   
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

        private void FRM_CAT_ADD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) simpleButton22_Click(btn_add, e);
        }

      
    }
}
