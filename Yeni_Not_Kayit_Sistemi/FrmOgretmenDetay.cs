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

namespace Yeni_Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }







        private SqlConnection baglanti =
            new SqlConnection(
                @"Data Source=LAPTOP-IAK7778Q\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void button1OgrKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) VALUES (@P1,@P2,@P3)",
                baglanti);
            komut.Parameters.AddWithValue("@P1", maskedTextBox1Numara.Text);
            komut.Parameters.AddWithValue("@P2", textBox1Ad.Text);
            komut.Parameters.AddWithValue("@P3", textBox2Soyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Sisteme Basariyla Eklendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox3Sinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox5Sinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox4Sinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            maskedTextBox1Numara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2Soyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox1Ad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void button2NotKaydet_Click(object sender, EventArgs e)
        {
            string durum;
            
            double ortalama, s1, s2, s3;
            s1 = Convert.ToDouble(textBox3Sinav1.Text);
            s2 = Convert.ToDouble(textBox5Sinav2.Text);
            s3 = Convert.ToDouble(textBox4Sinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString();

            //int gecenSayisi = GetCountByDurum(true);
            //int kalanSayisi = GetCountByDurum(false);
            //LblGecensayisi.Text=gecenSayisi.ToString();
            //LblKalanSayisi.Text=kalanSayisi.ToString();
            if (ortalama > 50)
            {
                durum = "True";
                
            }
            else
            {
                durum = "False";
            }
            baglanti.Open();
            SqlCommand komut =
                new SqlCommand(
                    "update TBLDERS set OGRSINAV1=@P1,OGRSINAV2=@P2,OGRSINAV3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6",
                    baglanti);
            komut.Parameters.AddWithValue("@P1", textBox3Sinav1.Text);
            komut.Parameters.AddWithValue("@P2", textBox5Sinav2.Text);
            komut.Parameters.AddWithValue("@P3", textBox4Sinav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(LblOrtalama.Text));
            komut.Parameters.AddWithValue("@P5",durum);
            komut.Parameters.AddWithValue("@P6", maskedTextBox1Numara.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Notlari Guncellendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
        }



        private void button1KayitGincelle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =
                new SqlCommand(
                    "update TBLDERS set OGRAD=@P1,OGRSOYAD=@P2 WHERE OGRNUMARA=@P3",
                    baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1Ad.Text);
            komut.Parameters.AddWithValue("@P2", textBox2Soyad.Text);
            komut.Parameters.AddWithValue("@P3", maskedTextBox1Numara.Text);
       


            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci bILGILERI Guncellendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
        }
    }
}
