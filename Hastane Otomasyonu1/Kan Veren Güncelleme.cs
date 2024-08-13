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
    public partial class Kan_Veren_Güncelleme : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Kan_Veren_Güncelleme()
        {
            InitializeComponent();
        }
        void KanGüncelle()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM KanVerenlerinListesi", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }


        private void Kan_Veren_Güncelleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet4.KanVerenlerinListesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kanVerenlerinListesiTableAdapter.Fill(this.hastane_OtomasyonuDataSet4.KanVerenlerinListesi);

            KanGüncelle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE KanVerenlerinListesi SET Bagıscıİsmi=@Bagıscıİsmi,BagıscıSoyismi=@BagıscıSoyismi,BagıscıYası=@BagıscıYası,BagıscıCinsiyeti=@BagıscıCinsiyeti,BagıscıTcsi=@BagıscıTcsi,KanGrubu=@KanGrubu,ToplamKanVermeSayısı=@ToplamKanVermeSayısı WHERE BagısID=@BagısID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@BagısID", (textBox8.Text));
            komut.Parameters.AddWithValue("@Bagıscıİsmi", (textBox1.Text));
            komut.Parameters.AddWithValue("@BagıscıSoyismi", (textBox2.Text));
            komut.Parameters.AddWithValue("@BagıscıYası", (textBox3.Text));
            komut.Parameters.AddWithValue("@BagıscıCinsiyeti", (textBox4.Text));
            komut.Parameters.AddWithValue("@BagıscıTcsi", (textBox5.Text));
            komut.Parameters.AddWithValue("@KanGrubu", (textBox6.Text));
            komut.Parameters.AddWithValue("@ToplamKanVermeSayısı", (textBox7.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KanGüncelle();
        }
    }
}
