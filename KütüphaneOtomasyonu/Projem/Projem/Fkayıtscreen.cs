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
using System.Windows.Forms;

namespace Projem
{
    public partial class Fkayıtscreen : Form
    {
        public Fkayıtscreen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4O7UO30;Initial Catalog=Proje;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (String.IsNullOrEmpty(sifre_txt.Text) && String.IsNullOrEmpty(stekrar_txt.Text))
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            else if (sifre_txt.Text == stekrar_txt.Text)
            {
                SqlCommand komut = new SqlCommand("insert into KullanıcıGiris(adsoyad,kullanıcıadı,sifre,soru,cevap) values (@adsoyad,@kullanıcıadı,@sifre,@soru,@cevap  )", baglanti);
                komut.Parameters.AddWithValue("@adsoyad", adsoyad_txt.Text);
                komut.Parameters.AddWithValue("@kullanıcıadı", kad_txt.Text);
                komut.Parameters.AddWithValue("@sifre", sifre_txt.Text);
                komut.Parameters.AddWithValue("@soru", soru_txt.Text);
                komut.Parameters.AddWithValue("@cevap", cevap_txt.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt işlemi başarılı!");
                this.Hide();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
              
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hata");
            }


            baglanti.Close();
        }
        private void txt_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

 
        private void Fkayıtscreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Fkayıtscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sifre_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void stekrar_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void adsoyad_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void Fkayıtscreen_Load_1(object sender, EventArgs e)
        {

        }
    }
}
