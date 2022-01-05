using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    class KullanıcıForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4O7UO30;Initial Catalog=Proje;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        Fdefault yeni = new Fdefault();
        Fadmin admin = new Fadmin();
        //public SqlDataReader kullanıcı(TextBox kullanıcıadı, TextBox sifre)
        //{
        //    //string sorgu = "SELECT * FROM KullanıcıGiris where kullanıcıadı=@kullanıcıadı AND sifre=@sifre";

        //    //komut = new SqlCommand(sorgu, baglanti);
        //    //komut.Parameters.AddWithValue("@kullanıcıadı", kullanıcıadı.Text);
        //    //komut.Parameters.AddWithValue("@sifre", sifre.Text);
        //    //baglanti.Open();
        //    //read = komut.ExecuteReader();
        //    //if (read.Read())
        //    //{
        //    //    MessageBox.Show("Giriş başarılı");
        //    //    yeni.ShowDialog();
            
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata");
        //    //}
        //    //baglanti.Close();
        //    //return read;
           

        //}


        //public void yenikullanıcı(TextBox adsoyad, TextBox kullanıcıadı,TextBox sifre,TextBox sifretekrar,TextBox soru, TextBox cevap,GroupBox grup)
        //{
        //    if (sifre.Text==sifretekrar.Text)
        //    {
        //        baglanti.Open();
        //        komut = new SqlCommand();
        //        komut.Connection=baglanti;
        //        komut.CommandText = "insert into KullanıcıGiris values('"+adsoyad.Text+"','"+kullanıcıadı.Text+"','"+sifre.Text+"','"+soru.Text+ "','','" + cevap.Text + "','')";
        //        komut.ExecuteNonQuery();
        //        baglanti.Close();
        //        MessageBox.Show("Üye Eklendi");
        //        foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";

        //    }
        //    else
        //    {
        //        MessageBox.Show("Şifreler Uyuşmuyor","Hata");
        //    }
        //}
    }
}
