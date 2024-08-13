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
    public partial class Kan_Veren_Ekle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Kan_Veren_Ekle()
        {
            InitializeComponent();
        }
        void YeniKanEKle()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM KanVerenlerinListesi", baglanti);

            baglanti.Close();
        }

        private void Kan_Veren_Ekle_Load(object sender, EventArgs e)
        {
            YeniKanEKle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO KanVerenlerinListesi(Bagıscıİsmi,BagıscıSoyismi,BagıscıYası,BagıscıCinsiyeti,BagıscıTcsi,KanGrubu,ToplamKanVermeSayısı) VALUES(@Bagıscıİsmi,@BagıscıSoyismi,@BagıscıYası,@BagıscıCinsiyeti,@BagıscıTcsi,@KanGrubu,@ToplamKanVermeSayısı) ";
            komut = new SqlCommand(sorgu, baglanti);
            
            komut.Parameters.AddWithValue("@Bagıscıİsmi", textBox1.Text);
            komut.Parameters.AddWithValue("@BagıscıSoyismi", textBox2.Text);
            komut.Parameters.AddWithValue("@BagıscıYası", textBox3.Text);
            komut.Parameters.AddWithValue("@BagıscıCinsiyeti", textBox4.Text);
            komut.Parameters.AddWithValue("@BagıscıTcsi", textBox5.Text);
            komut.Parameters.AddWithValue("@KanGrubu", textBox6.Text);
            komut.Parameters.AddWithValue("@ToplamKanVermeSayısı", textBox7.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            Kan_Verenlerin_Listesi knvrnlst1 = new Kan_Verenlerin_Listesi();
            knvrnlst1.Show();
            this.Hide();


        }
    }
}
