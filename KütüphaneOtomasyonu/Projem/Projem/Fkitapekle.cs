using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    public partial class Fkitapekle : Form
    {
        public Fkitapekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4O7UO30;Initial Catalog=Proje;Integrated Security=True");

        private void Fkitapekle_Load(object sender, EventArgs e)
        {
             this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (String.IsNullOrEmpty(txtBarkodNo.Text) && String.IsNullOrEmpty(txtKitapAdi.Text))
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Kitap(barkodno,kitapadi,yazari,yayınevi,sayfasayisi,turu,stoksayisi,rafno,aciklama,kayıttarihi) values (@barkodno,@kitapadi,@yazari,@yayınevi,@sayfasayisi,@turu,@stoksayisi,@rafno,@aciklama,@kayıttarihi)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
                komut.Parameters.AddWithValue("@yayınevi", txtYayınEvi.Text);
                komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@turu", comboTürü.Text);
                komut.Parameters.AddWithValue("@stoksayisi", txtStokSayısı.Text);
                komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
                komut.Parameters.AddWithValue("@aciklama", txtAçıklama.Text);
                komut.Parameters.AddWithValue("@kayıttarihi", DateTime.Now.ToShortDateString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt işlemi başarılı!");
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }
                }
            }
            
            
            baglanti.Close();
        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKitapAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtYazari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtYayınEvi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStokSayısı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRafNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAçıklama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
