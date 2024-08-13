using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hastane_Otomasyonu1
{
    public partial class Kan_Verenlerin_Listesi : Form
    {
        
        public Kan_Verenlerin_Listesi()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Kan_Veren_Güncelleme knvrngnclm1 = new Kan_Veren_Güncelleme();
            knvrngnclm1.Show();
        }

        private void Kan_Verenlerin_Listesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet4.KanVerenlerinListesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kanVerenlerinListesiTableAdapter2.Fill(this.hastane_OtomasyonuDataSet4.KanVerenlerinListesi);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kan_Veren_Ekle knvrnekle1 = new Kan_Veren_Ekle();
            knvrnekle1.Show();
        }
    }
}
