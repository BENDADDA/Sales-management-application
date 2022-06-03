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

    
    public partial class FRM_SAL : Form
    {
        DB_SMPEntities3 db = new DB_SMPEntities3();
        TB_SELL tb = new TB_SELL();
        public string str1;
        public string str2;
        public int id=1;
        public int id1;
        public FRM_SAL()
        {
            InitializeComponent();
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {
            calcul();
        }

        private void ebt_name_TextChanged(object sender, EventArgs e)
        {
            calcul();
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {
           

        }

        private void label6_Click(object sender, EventArgs e)
        {
            PL.FRM_PUR frm = new PL.FRM_PUR();
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TB_PUR tb = new TB_PUR();
                tb = db.TB_PUR.Where(x => x.Pur_Name == comboBox1.Text).FirstOrDefault();
                label01.Text = (purchase = Convert.ToDouble(tb.Pur_Buy)).ToString() + "$";
                label02.Text = (tpurchase = Convert.ToDouble(tb.Pur_Tbuy)).ToString() + "$";
                label03.Text = (Sale = Convert.ToDouble(tb.Pur_Sell)).ToString() + "$";
                label04.Text = (tsale = Convert.ToDouble(tb.Pur_Tsell)).ToString() + "$";
                label05.Text = (quantity = Convert.ToDouble(tb.Pur_Qt)).ToString();
                textBoxs.Text = (s = Convert.ToDouble(tb.Pur_Sell)).ToString();
                calcul();
            }
            catch { }
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.ForestGreen;
            label8.Font = new Font(label8.Text, label8.Font.Size, FontStyle.Underline);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.DarkGreen;
            label9.Font = new Font(label9.Text, label9.Font.Size);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.DarkGreen;
            label8.Font = new Font(label8.Text, label8.Font.Size);
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.ForestGreen;
            label9.Font = new Font(label9.Text, label9.Font.Size,FontStyle.Underline);
        }
        bool vs=true;
        private void nol(object sender, EventArgs e)
        {

          DB_SMPEntities3 db = new DB_SMPEntities3();
          TB_SELL tb = new TB_SELL(); 
          Toast toast = new Toast();
            if (comboBox1.Text==""||comboBox2.Text==""||textBoxs.Text=="")
            {

               
                MessageBoxButtons msbutton = MessageBoxButtons.OK;
                MessageBox.Show("Please write all informations", "Information", msbutton, MessageBoxIcon.Information);

            }
            else
            {

                if (vs) 
                {
                    MessageBoxButtons msbutton = MessageBoxButtons.OK;
                    MessageBox.Show("Enter numbers in Selling price", "Information", msbutton, MessageBoxIcon.Information);
                    return;
                }






                if (id == 1)//Add
                {
                    try
                    {
                       
                       
                      
                        tb.Sell_Name= comboBox1.Text;
                        tb.Sell_Cus = comboBox2.Text;
                        tb.Sell_Qt = q;
                        tb.Sell_Price = s;
                        tb.Sell_TPrice = ts;
                        DateTime mydate = DateTime.Now;
                        tb.Sell_Date = mydate;
                        db.TB_SELL.AddObject(tb);
                        db.SaveChanges();
                        toast.label1.Text = "Selling";
                        toast.Show();
                        this.Close();

                    }
                    catch { }
                }
                else//edit
                {
                    try
                    {
                        db = new DB_SMPEntities3();
                        tb = new TB_SELL();
                        tb = db.TB_SELL.Where(x => x.ID == id1).FirstOrDefault();
                        db.TB_SELL.DeleteObject(tb);
                        db.SaveChanges();

                        tb.Sell_Name = comboBox1.Text;
                        tb.Sell_Cus = comboBox2.Text;
                        tb.Sell_Qt = q;
                        tb.Sell_Price = s;
                        tb.Sell_TPrice = ts;
                        DateTime mydate = DateTime.Now;
                        tb.Sell_Date = mydate;
                        db.TB_SELL.AddObject(tb);
                       
                        
                        db.SaveChanges();
                        toast.label1.Text = "Selling edited";
                        toast.Show();
                        this.Close();

                    }
                    catch { }

                        
                
                }
            }
        }
        public decimal q01;
        private void FRM_PUR_Activated(object sender, EventArgs e)
        {
           comboBox1.DataSource= db.TB_PUR.Select(x => x.Pur_Name).ToList();
           comboBox2.DataSource= db.TB_CUS.Select(x => x.Sup_Name).ToList();
          

            if (str1 != null)
            {
                comboBox1.Text = str1;
                comboBox2.Text = str2;
                spinEditq.Value = q01;
            }
        }

        private void gvtrg(object sender, EventArgs e)
        {
            PL.FRM_CUS frm = new PL.FRM_CUS();
            frm.ShowDialog();
        }
        double purchase, Sale, quantity, tpurchase, tsale,s,ts,q,p;
        private void calcul()
        {
            TB_PUR tb1 = new TB_PUR();
            TB_CUS tb2 = new TB_CUS();
            TB_SELL tb = new TB_SELL();
            try
            {

                s = Convert.ToDouble(textBoxs.Text);
                q = Convert.ToDouble(spinEditq.Value);
                labelS.Text = (ts = s * q).ToString()+"$";
                if (q != 0)
                {

                    labelT.Text = (p = ts - tpurchase).ToString() + "$";
                }
                else
                {
                    labelT.Text = (p =0).ToString() + "$";
                }

               
                vs = false;
            }
            catch { vs = true; }


        }

        private void spinEditq_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(spinEditq.Value) > quantity) spinEditq.Value = Convert.ToDecimal(quantity);
            calcul();

        }

        private void tgrtg(object sender, EventArgs e)
        {
            calcul();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}
