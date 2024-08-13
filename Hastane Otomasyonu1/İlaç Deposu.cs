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
    public partial class İlaç_Deposu : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public İlaç_Deposu()
        {
            InitializeComponent();
        }
        void İlacSil()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM İlac", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
            baglanti.Close();

        }


        private void İlaç_Deposu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet1.İlac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlacTableAdapter.Fill(this.hastane_OtomasyonuDataSet1.İlac);

            İlacSil();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            İlac_Ekle_Formu ilcekle1 = new İlac_Ekle_Formu();
            ilcekle1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM İlac WHERE İlacID=@İlacID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@İlacID", Convert.ToInt32(dataGridView1.SelectedRows.Count));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            İlacSil();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İlaç_Güncelle_Formu gnclmfrm1 = new İlaç_Güncelle_Formu();
            gnclmfrm1.Show();
        
        }
    }
}
