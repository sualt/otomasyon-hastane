using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hastane_Otomasyonu1
{
    
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NFT4KIO\\SQLEXPRESS;initial catalog=Hastane Otomasyonu; integrated security=true");
        SqlDataAdapter adtr;
        SqlCommand komut;
        DataTable tablo = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        void KayitGoster()
        {
            tablo.Clear();
            adtr = new SqlDataAdapter("Goster", connection);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            KayitGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Hasta WHERE HastaID=@HastaID";
            komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@HastaID", Convert.ToInt32(dataGridView1.SelectedRows.Count));
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
            KayitGoster();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Güncelleme_Formu gnclmfrm1 = new Güncelleme_Formu();
            gnclmfrm1.Show();
        }
    }
}
