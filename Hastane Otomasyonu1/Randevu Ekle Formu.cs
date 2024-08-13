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
    public partial class Form6 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form6()
        {
            InitializeComponent();
        }
        void RandevuEkleme()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Randevu", baglanti);
           
            baglanti.Close();

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            RandevuEkleme();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Randevu(HastaAdı,HastaSoyadı,HastaTcNo,RandevuTarihi,Doktor,Bölüm,Cinsiyet) VALUES(@HastaAdı,@HastaSoyadı,@HastaTcNo,@RandevuTarihi,@Doktor,@Bölüm,@Cinsiyet) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@HastaAdı", textBox1.Text);
            komut.Parameters.AddWithValue("@HastaSoyadı", textBox2.Text);
            komut.Parameters.AddWithValue("@HastaTcNo", textBox3.Text);
            komut.Parameters.AddWithValue("@RandevuTarihi",textBox4.Text);
            komut.Parameters.AddWithValue("@Doktor", textBox5.Text);
            komut.Parameters.AddWithValue("@Bölüm", textBox6.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox7.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
           

        }
    }
}
