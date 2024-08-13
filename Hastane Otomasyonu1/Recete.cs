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
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }

        private void Recete_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet7.Recete' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.receteTableAdapter1.Fill(this.hastane_OtomasyonuDataSet7.Recete);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceteEkle rctekle = new ReceteEkle();
            rctekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receteİslem rctislm = new Receteİslem();
            rctislm.Show();
        }
    }
}
