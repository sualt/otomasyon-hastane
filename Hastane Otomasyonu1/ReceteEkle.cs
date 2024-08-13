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
    public partial class ReceteEkle : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;

        public ReceteEkle()
        {
            InitializeComponent();
        }
        void ReceteEkleme()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Recete", baglanti);

            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Recete(ReceteID,HastaID,ReceteTarihi,DoktorAdı,İlaclar,Miktar) VALUES(@ReceteID,@HastaID,@ReceteTarihi,@DoktorAdı,@İlaclar,@Miktar) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ReceteID", textBox1.Text);
            komut.Parameters.AddWithValue("@HastaID", textBox2.Text);
            komut.Parameters.AddWithValue("@ReceteTarihi", textBox3.Text);
            komut.Parameters.AddWithValue("@DoktorAdı", textBox4.Text);
            komut.Parameters.AddWithValue("@İlaclar", richTextBox1.Text);
            komut.Parameters.AddWithValue("@Miktar", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            Recete rctekleme = new Recete();
            rctekleme.Show();
            this.Hide();
        }

        private void ReceteEkle_Load(object sender, EventArgs e)
        {
            ReceteEkleme();
        }
    }
}
