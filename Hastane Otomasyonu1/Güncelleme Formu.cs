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
    public partial class Güncelleme_Formu : Form
    {
        SqlConnection baglanma;
        SqlCommand Command;
        SqlDataAdapter da;
        public Güncelleme_Formu()
        {
            InitializeComponent();
        }
        void HastaGüncelle()
        {
            baglanma = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanma.Open();
            da = new SqlDataAdapter("SELECT * FROM Hasta", baglanma);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanma.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Hasta SET HastaAd=@HastaAd,HastaSoyad=@HastaSoyad,HastaTcNo=@HastaTcNo,HastaDogumYılı=@HastaDogumYılı,HastaCinsiyet=@HastaCinsiyet,HastaDoktorAd=@HastaDoktorAd,HastaBölümAd=@HastaBölümAd WHERE HastaID=@HastaID";
            Command = new SqlCommand(sorgu, baglanma);
            Command.Parameters.AddWithValue("@HastaID", (textBox1.Text));
            Command.Parameters.AddWithValue("@HastaAd", (textBox2.Text));
            Command.Parameters.AddWithValue("@HastaSoyad", (textBox3.Text));
            Command.Parameters.AddWithValue("@HastaTcNo", (textBox4.Text));
            Command.Parameters.AddWithValue("@HastaCinsiyet", (textBox6.Text));
            Command.Parameters.AddWithValue("@HastaDogumYılı", (textBox7.Text));
            Command.Parameters.AddWithValue("@HastaDoktorAd", (textBox5.Text));
            Command.Parameters.AddWithValue("@HastaBölümAd", (textBox8.Text));
            baglanma.Open();
            Command.ExecuteNonQuery();
            baglanma.Close();
            HastaGüncelle();
        }

        private void Güncelleme_Formu_Load(object sender, EventArgs e)
        {
            HastaGüncelle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
