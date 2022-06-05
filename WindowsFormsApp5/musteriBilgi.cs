using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class musteriBilgi : Form
    {
        public musteriBilgi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void musteriBilgi_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            listBox1.Visible = false;
            label8.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
           listBox1.Items.Add(" müsteri adı : "+textBox1.Text);
            listBox1.Items.Add(" müsteri soyadı : " + textBox2.Text);
            listBox1.Items.Add("ödeme şekliniz: " + comboBox1.SelectedItem);
            listBox1.Items.Add(" sipariş no : " + textBox3.Text);
            listBox1.Items.Add(" müsteri telefon no : " + textBox4.Text);
            listBox1.Items.Add(" müsteri adresi : " + textBox5.Text);
            listBox1.Visible = true;
            label8.Visible = true;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "kebab : 10 tl")
            {
                groupBox2.Visible = true;
            }
        }
             string tumSipariş=" ";
                int toplamTutar=0,adet;
      

        private void button3_Click(object sender, EventArgs e)
        {
                //lahmacun: 5.00 tl
                // pizza : 15 tl
                //kebab : 10 tl
         
            if (comboBox2.SelectedIndex == 0)
            {
                 adet = Convert.ToInt32(numericUpDown1.Value);
                tumSipariş +="\n "+adet+" adet lahmacun";
                toplamTutar += adet*5;

            


            }
           else if (comboBox2.SelectedIndex == 1)
            {
                adet = Convert.ToInt32(numericUpDown1.Value);
                tumSipariş += "\n " + adet + " adet pizza";
                toplamTutar += adet * 15;
            }
            else if (comboBox2.SelectedIndex == 2)
            {   
                adet = Convert.ToInt32(numericUpDown1.Value);
                if(checkBox1.Checked == true) 
                {
                   
                    tumSipariş += "\n " + adet + " adet adana kebab";
                    toplamTutar += adet * 10;
                }
               if  (checkBox2.Checked == true)
                {
                    
                    tumSipariş += "\n " + adet + " adet urfa kebab";
                    toplamTutar += adet * 10;
                }
                
               
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fatura fatura = new fatura();
            fatura.listBox1.Items.Add(tumSipariş);
            fatura.listBox1.Items.Add("toplam tutar: " + toplamTutar);
            fatura.Show();

        }
    }
}
