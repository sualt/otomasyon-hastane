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
    public partial class Arayüz : Form
    {
        public Arayüz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            İlaç_Deposu ilcdps1 = new İlaç_Deposu();
            ilcdps1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kan_Verenlerin_Listesi knvrnlsts1 = new Kan_Verenlerin_Listesi();
            knvrnlsts1.Show();
        }

        private void Arayüz_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recete frm_Recete = new Recete();
            frm_Recete.Show();
        }
    }
}
