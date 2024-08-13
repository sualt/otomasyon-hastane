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
    public partial class Form4 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form4()
        {
            InitializeComponent();
        }
        void HastaEkle()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Hasta", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Hasta(HastaID,HastaAd,HastaSoyad,HastaTcNo,HastaCinsiyet,HastaDogumYılı,HastaDoktorAd,HastaBölümAd) VALUES(@HastaID,@HastaAd,@HastaSoyad,@HastaTcNo,@HastaCinsiyet,@HastaDogumYılı,@HastaDoktorAd,@HastaBölümAd) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@HastaID", textBox1.Text);
            komut.Parameters.AddWithValue("@HastaAd", textBox2.Text);
            komut.Parameters.AddWithValue("@HastaSoyad", textBox3.Text);
            komut.Parameters.AddWithValue("@HastaTcNo", textBox4.Text);
            komut.Parameters.AddWithValue("@Hastacinsiyet", textBox6.Text);
            komut.Parameters.AddWithValue("@HastaDogumYılı", textBox7.Text);
            komut.Parameters.AddWithValue("@HastaDoktorAd", textBox5.Text);
            komut.Parameters.AddWithValue("@HastaBölümAd", textBox8.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            HastaEkle();

          
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            HastaEkle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
