using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = "Mustafa Kılıç";
            string sifre = "Mustafa4156";
            if (textBox1.Text == kullaniciadi && textBox2.Text == sifre)
            {
                Arayüz frm3 = new Arayüz();
                frm3.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı Bilgi");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
