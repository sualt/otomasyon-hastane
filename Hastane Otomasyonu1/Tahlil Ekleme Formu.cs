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
    public partial class Form7 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;

        public Form7()
        {
            InitializeComponent();
        }

        void TahlilEkle()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Tahlil", baglanti);
         
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Tahlil(TahlilID,TahlilAd,TahlilAcıklama) VALUES(@TahlilID,@TahlilAd,@TahlilAcıklama) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TahlilID", textBox1.Text);
            komut.Parameters.AddWithValue("@TAhlilAd", textBox2.Text);
            komut.Parameters.AddWithValue("@TahlilAcıklama", richTextBox1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet5.Tahlil' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tahlilTableAdapter.Fill(this.hastane_OtomasyonuDataSet5.Tahlil);

            TahlilEkle();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Tahlil WHERE TahlilID=@TahlilID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TahlilID", Convert.ToInt32(dataGridView1.SelectedRows.Count));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TahlilEkle();
        }
    }
}
