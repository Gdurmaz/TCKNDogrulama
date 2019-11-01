using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTCKN.Text) && !string.IsNullOrEmpty(tbAd.Text) && !string.IsNullOrEmpty(tbSoyad.Text) && !string.IsNullOrEmpty(tbDogum.Text))
            {
                //Web Services - Web Service Projecisi olarak oluştur.
                TCKNKontrol.KPSPublic kps = new TCKNKontrol.KPSPublic();
                bool IsControl = kps.TCKimlikNoDogrula(long.Parse(tbTCKN.Text), tbAd.Text.ToUpper(), tbSoyad.Text.ToUpper(), Convert.ToInt32(tbDogum.Text));
                if (IsControl == true)
                {
                    MessageBox.Show("Bilgileriniz Doğrulandı");
                }
                else
                {
                    MessageBox.Show("Bilgileriniz Doğrulanmadı");
                }
            }
            else
            {
                MessageBox.Show("Eksik bilgi girdiniz");

            }
        }
        //Ad ve Soyad için sayı girilemez
        private void tbAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
        //TCKN ve Doğum Yılı için harf girilemez
        private void tbTCKN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
