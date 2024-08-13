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
    public partial class Form5 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form5()
        {
            InitializeComponent();
        }
        void RandevuEkle()
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
            Form6 frm6 = new Form6();
            frm6.Show();

            RandevuEkle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_OtomasyonuDataSet.Randevu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevuTableAdapter.Fill(this.hastane_OtomasyonuDataSet.Randevu);

        }
    }
}
