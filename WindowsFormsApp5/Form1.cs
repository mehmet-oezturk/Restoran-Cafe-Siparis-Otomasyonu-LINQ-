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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                musteriBilgi git = new musteriBilgi();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlış şifre veya kullanıcı adı girdiniz tekrar deneyiniz");
            }
        }
    }
}
