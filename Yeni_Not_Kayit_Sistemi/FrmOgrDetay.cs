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
    public partial class FrmOgrDetay : Form
    {
        public FrmOgrDetay()
        {
            InitializeComponent();
        }

        public string numara;

        private SqlConnection baglanti =
            new SqlConnection(
                @"Data Source=LAPTOP-IAK7778Q\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblOgrNumarasi.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[2].ToString() + "" + dr[3].ToString();
                LblSinav1Sonuc.Text = dr[4].ToString();
                LblSinav2Sonuc.Text = dr[5].ToString();
                LblSinav3onuc.Text= dr[6].ToString();
                LblOrtalama.Text= dr[7].ToString();
                LblOgrDurum.Text= dr[8].ToString();

            }
            baglanti.Close();
        }


    }
}
