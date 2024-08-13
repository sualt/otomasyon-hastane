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
    public partial class İlaç_Güncelle_Formu : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public İlaç_Güncelle_Formu()
        {
            InitializeComponent();
        }
        void İlacGüncelle()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM İlac", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void İlaç_Güncelle_Formu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet1.İlac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlacTableAdapter.Fill(this.hastane_OtomasyonuDataSet1.İlac);

            İlacGüncelle();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE İlac SET İlacAd=@İlacAd,İlacFirması=@İlacFirması,İlacAcıklama=@İlacAcıklama WHERE İlacID=@İlacID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@İlacID", (textBox1.Text));
            komut.Parameters.AddWithValue("@İlacAd", (textBox2.Text));
            komut.Parameters.AddWithValue("@İlacFirması", (textBox3.Text));
            komut.Parameters.AddWithValue("@İlacAcıklama", (richTextBox1.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            İlacGüncelle();

            İlaç_Deposu ilcdps1 = new İlaç_Deposu();
            ilcdps1.Show();
            this.Hide();
        }
    }
}
