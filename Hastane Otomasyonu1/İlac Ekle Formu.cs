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
    public partial class İlac_Ekle_Formu : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public İlac_Ekle_Formu()
        {
            InitializeComponent();
        }
        void İlacEkle()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM İlac", baglanti);
            baglanti.Close();

        }

        private void İlac_Ekle_Formu_Load(object sender, EventArgs e)
        {
            İlacEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO İlac(İlacID,İlacAd,İlacFirması,İlacAcıklama) VALUES(@İlacID,@İlacAd,@İlacFirması,@İlacAcıklama) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@İlacID", textBox1.Text);
            komut.Parameters.AddWithValue("@İlacAd", textBox2.Text);
            komut.Parameters.AddWithValue("@İlacFirması", textBox3.Text);
            komut.Parameters.AddWithValue("@İlacAcıklama", richTextBox1.Text);
      
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            İlacEkle();

            İlaç_Deposu ilcdps1 = new İlaç_Deposu();
            ilcdps1.Show();
            this.Hide();

        }
    }
}
