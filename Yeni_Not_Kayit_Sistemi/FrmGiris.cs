using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeni_Not_Kayit_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmGirisYap_Click(object sender, EventArgs e)
        {
            FrmOgrDetay frmOgrDetay=new FrmOgrDetay();
            frmOgrDetay.numara = maskedTextOgrNumberText.Text;
            frmOgrDetay.Show();
            //this.Hide();
            
        }

        private void maskedTextOgrNumberText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextOgrNumberText_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextOgrNumberText.Text == "1111")
            {
                FrmOgretmenDetay frmOgretmenDetay=new FrmOgretmenDetay();
                frmOgretmenDetay.Show();
            }
        }
    }
}
