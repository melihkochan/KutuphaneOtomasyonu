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
    public partial class Fkgiris : Form
    {
        public Fkgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4O7UO30;Initial Catalog=Proje;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        

    
        //KullanıcıForm k = new KullanıcıForm();
 
        private void btn_ekle_Click(object sender, EventArgs e)
        {
          
            //baglanti.Open();
            //if (String.IsNullOrEmpty(sifre_txt.Text) && String.IsNullOrEmpty(stekrar_txt.Text))
            //{
            //    MessageBox.Show("boş alan bırakmayınız");
            //}
            //else if (sifre_txt.Text == stekrar_txt.Text)
            //{  
            //    SqlCommand komut = new SqlCommand("insert into KullanıcıGiris(adsoyad,kullanıcıadı,sifre,soru,cevap) values (@adsoyad,@kullanıcıadı,@sifre,@soru,@cevap  )", baglanti);
            //    komut.Parameters.AddWithValue("@adsoyad", adsoyad_txt.Text);
            //    komut.Parameters.AddWithValue("@kullanıcıadı", kad_txt.Text);
            //    komut.Parameters.AddWithValue("@sifre", sifre_txt.Text);
            //    komut.Parameters.AddWithValue("@soru", soru_txt.Text);
            //    komut.Parameters.AddWithValue("@cevap", cevap_txt.Text);
            //    komut.ExecuteNonQuery();
            //    baglanti.Close();
            //    MessageBox.Show("Kayıt işlemi başarılı!");
            //    foreach (Control item in Controls)
            //    {
            //        if (item is TextBox)
            //        {
            //            item.Text = "";

            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Şifreler Uyuşmuyor", "Hata");
            //}


            //baglanti.Close();
        }

        private void txt_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void adsoyad_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void sifre_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void stekrar_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Fkgiris_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Fkgiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

     

        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_kad.Text) && String.IsNullOrEmpty(txt_sifre.Text))
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            else
            {
                //k.kullanıcı(txt_kad,txt_sifre);
                bool f = true;
                string asorgu = "SELECT * FROM AdminUser where akullanıcıadı=@akullanıcıadı AND asifre=@asifre";

                komut = new SqlCommand(asorgu, baglanti);
                komut.Parameters.AddWithValue("@akullanıcıadı", txt_kad.Text);
                komut.Parameters.AddWithValue("@asifre", txt_sifre.Text);
                baglanti.Open();
                read = komut.ExecuteReader();
                if (read.Read())
                {
                    f = false;
                    Fadmin admin = new Fadmin();
                    admin.Show();
                    this.Hide();

                }
                baglanti.Close();
                if (f)
                {
                    string sorgu = "SELECT * FROM KullanıcıGiris where kullanıcıadı=@kullanıcıadı AND sifre=@sifre";

                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kullanıcıadı", txt_kad.Text);
                    komut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
                    baglanti.Open();
                    read = komut.ExecuteReader();
                    if (read.Read())
                    {
                        MessageBox.Show("Giriş başarılı");
                        Fdefault yeni = new Fdefault();
                        yeni.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata");
                    }

                    baglanti.Close();
                }
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Fkayıtscreen kayıtgecis = new Fkayıtscreen();
            kayıtgecis.ShowDialog();
        }
    }
}
