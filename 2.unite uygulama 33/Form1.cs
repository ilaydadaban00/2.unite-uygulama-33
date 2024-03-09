using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi;
            long parola;
            try
            {
                kullaniciAdi = txtKullanici_Adi.Text.ToString();
                parola = long.Parse(txtKullanici_Adi.Text.ToString());
                MessageBox.Show("Giriş Başarılı.Hoşgeldiniz " +kullaniciAdi);
            }
            catch (Exception)
            {
                MessageBox.Show("Şifreniz Sadece Sayılardan Oluşmalıdır.Tekrar Deneyiniz.");
               txtKullanici_Adi.Text = "";
            }
            finally
            {
            }
        }
    }
}
