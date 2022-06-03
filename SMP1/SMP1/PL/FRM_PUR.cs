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

    
    public partial class FRM_PUR : Form
    {
        DB_SMPEntities3 db = new DB_SMPEntities3();
        TB_PUR tb = new TB_PUR();
        public string str1;
        public string str2;
        public int id=1;
        public int id1;
        public FRM_PUR()
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
            PL.FRM_CAT_ADD frm = new FRM_CAT_ADD();
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
          TB_PUR tb = new TB_PUR(); 
          Toast toast = new Toast();
            if (ebt_name.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textboxp.Text==""
                || textBoxs.Text=="")
            {

               
                MessageBoxButtons msbutton = MessageBoxButtons.OK;
                MessageBox.Show("Please write all informations", "Information", msbutton, MessageBoxIcon.Information);

            }
            else
            {

                if (vs) 
                {
                    MessageBoxButtons msbutton = MessageBoxButtons.OK;
                    MessageBox.Show("Enter numbers in Purchase price,Selling price", "Information", msbutton, MessageBoxIcon.Information);
                    return;
                }






                if (id == 1)//Add
                {
                    try
                    {
                       
                        tb.Pur_Name = ebt_name.Text;
                        tb.Pur_Type = textBox1.Text;
                        tb.Pur_Cat = comboBox1.Text;
                        tb.Pur_Supp = comboBox2.Text;
                        tb.Pur_Qt = quantity;
                        tb.Pur_Sell = Sale;
                        tb.Pur_Buy = purchase;
                        tb.Pur_Det = textBox2.Text;
                        tb.Pur_Tbuy = tpurchase;
                        tb.Pur_Tsell = tsale;
                        tb.Pur_TRev = profit;
                        db.TB_PUR.AddObject(tb);
                        db.SaveChanges();
                        toast.label1.Text = "A new Purchase is added";
                        toast.Show();
                        this.Close();

                    }
                    catch { }
                }
                else//edit
                {
                    try
                    {
                        tb = db.TB_PUR.Where(x => x.ID == id1).FirstOrDefault();
                        db.TB_PUR.DeleteObject(tb);
                        db.SaveChanges();
                        db = new DB_SMPEntities3();
                        tb = new TB_PUR();
                        tb.Pur_Name = ebt_name.Text;
                        tb.Pur_Type = textBox1.Text;
                        tb.Pur_Cat = comboBox1.Text;
                        tb.Pur_Supp = comboBox2.Text;
                        tb.Pur_Qt = quantity;
                        tb.Pur_Sell = Sale;
                        tb.Pur_Buy = purchase;
                        tb.Pur_Det = textBox2.Text;
                        tb.Pur_Tbuy = tpurchase;
                        tb.Pur_Tsell = tsale;
                        tb.Pur_TRev = profit;
                        db.TB_PUR.AddObject(tb);
                        db.SaveChanges();
                        toast.label1.Text = "A new Purchase is edited";
                        toast.Show();
                        this.Close();

                    }
                    catch { }

                        
                
                }
            }
        }

        private void FRM_PUR_Activated(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.TB_CAT.Select(x => x.CAT_Name).ToList();
            comboBox2.DataSource = db.TB_SUP.Select(x => x.Sup_Name).ToList();
            if (str1 != null)
            {
                comboBox1.Text = str1;
                comboBox2.Text = str2;
            }
        }

        private void gvtrg(object sender, EventArgs e)
        {
            PL.FRM_SUP frm = new FRM_SUP();
            frm.ShowDialog();
        }
        double purchase, Sale, quantity, tpurchase, tsale,profit;
        private void calcul()
        {
            try
            {
                purchase = Convert.ToDouble(textboxp.Text);
                Sale = Convert.ToDouble(textBoxs.Text);
                quantity = Convert.ToDouble(spinEditq.Value);
                tpurchase = quantity * purchase;
                tsale = Sale * quantity;
                profit = tsale - tpurchase;
                label1p.Text = tpurchase.ToString()+"$";
                label1s.Text = tsale.ToString()+"$";
                labelt.Text = profit.ToString()+"$";
                vs = false;
            }
            catch { vs = true; }


        }

        private void spinEditq_EditValueChanged(object sender, EventArgs e)
        {
            calcul();
        }

        private void tgrtg(object sender, EventArgs e)
        {
            calcul();

        }
      
    }
}
