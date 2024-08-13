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
    public partial class Receteİslem : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        SqlDataAdapter da;

        public Receteİslem()
        {
            InitializeComponent();
        }

        void Receteİslemi()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Recete", baglanti);
           
            baglanti.Close();
        }

        private void Receteİslem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet8.Recete' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.receteTableAdapter.Fill(this.hastane_OtomasyonuDataSet8.Recete);

            Receteİslemi();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Recete SET HastaID=@HastaID,ReceteTarihi=@ReceteTarihi,DoktorAdı=@DoktorAdı,İlaclar=@İlaclar,Miktar=@Miktar WHERE ReceteID=@ReceteID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ReceteID", (textBox1.Text));
            komut.Parameters.AddWithValue("@HastaID", (textBox2.Text));
            komut.Parameters.AddWithValue("@ReceteTarihi", (textBox3.Text));
            komut.Parameters.AddWithValue("@DoktorAdı", (textBox4.Text));
            komut.Parameters.AddWithValue("@İlaclar", (richTextBox1.Text));
            komut.Parameters.AddWithValue("@Miktar", (textBox5.Text));
            


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Receteİslemi();

            Receteİslem rctislem = new Receteİslem();
            rctislem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Recete WHERE ReceteID=@ReceteID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ReceteID", Convert.ToInt32(dataGridView1.SelectedRows.Count));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Receteİslemi();

            Receteİslem rectislem = new Receteİslem();
            rectislem.Show();
            this.Hide();
        }
    }
}
