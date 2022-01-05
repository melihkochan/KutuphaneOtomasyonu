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
    public partial class Femanetislem : Form
    {
        public Femanetislem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4O7UO30;Initial Catalog=Proje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitapadi,yazari,yayınevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@barkodno,@kitapadi,@yazari,@yayınevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txt_barkod.Text);
            komut.Parameters.AddWithValue("@kitapadi", txt_kitapadı.Text);
            komut.Parameters.AddWithValue("@yazari", txt_yazar.Text);
            komut.Parameters.AddWithValue("@yayınevi", txt_yayınevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txt_sayfasayısı.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txt_kitapsayısı.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) sepete eklendi","Ekleme İşlemi");
            daset.Tables["sepet"].Clear();
            sepetListele();
            lbl_kitapsayı.Text = "";
            kitapsayisi();
            foreach (Control item in grp_hesap.Controls)
            {
                if (item is TextBox)
                {
                    if (item!=txt_kitapsayısı)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet",baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }


        private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from sepet",baglanti);
            lbl_kitapsayı.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();   
        }
        private void Flogin_Load(object sender, EventArgs e)
        {
            sepetListele();
            kitapsayisi();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uye where tc like'%" + txt_tc.Text+ "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_adsoyad.Text = read["adsoyad"].ToString();
                txt_yas.Text = read["yas"].ToString();
                txt_telefon.Text = read["telefon"].ToString();
                 
            } 
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from EmanetKitaplarr where tc='" + txt_tc.Text+"'",baglanti);
            lbl_kayıtlıkitapsayı.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txt_tc.Text=="")
            {
                foreach (Control item in grp_üye.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        
                    }
                    
                }
                lbl_kayıtlıkitapsayı.Text = "";
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt Silinsin mi ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılı", "Silme İşlemi");
                daset.Tables["sepet"].Clear();
                sepetListele();
                lbl_kitapsayı.Text = "";
                kitapsayisi();
            }
          
        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitap where barkodno like'%"+txt_barkod.Text+ "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt_kitapadı.Text = read["kitapadi"].ToString();
                txt_yazar.Text = read["yazari"].ToString();
                txt_yayınevi.Text = read["yayınevi"].ToString();
                txt_sayfasayısı.Text = read["sayfasayisi"].ToString();
    
            }
            baglanti.Close();
            if (txt_barkod.Text=="")
            {
                foreach (Control item in grp_hesap.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txt_kitapsayısı)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            
        }

        private void btn_teslim_Click(object sender, EventArgs e)
        {

            if (lbl_kitapsayı.Text!="")
            {
                if (lbl_kayıtlıkitapsayı.Text=="" && int.Parse(lbl_kitapsayı.Text)<=3 || lbl_kayıtlıkitapsayı.Text!="" && int.Parse(lbl_kayıtlıkitapsayı.Text)+int.Parse(lbl_kitapsayı.Text) <=3)
                {
                    if (txt_tc.Text!="" && txt_adsoyad.Text!="" && txt_yas.Text!="" && txt_telefon.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {

                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into EmanetKitaplarr(tc,adsoyad,yas,telefon,barkodno,kitapadi,yazari/*,yayinevi*/,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@tc,@adsoyad,@yas,@telefon,@barkodno,@kitapadi,@yazari/*,@yayinevi*/,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc",txt_tc.Text);
                            komut.Parameters.AddWithValue("@adsoyad", txt_adsoyad.Text);
                            komut.Parameters.AddWithValue("@yas", txt_yas.Text);
                            komut.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                            komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            komut.Parameters.AddWithValue("@yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            //komut.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update Uye set okukitapsayisi=okukitapsayisi+'"+int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString())+"' where tc='"+txt_tc.Text+"'",baglanti);
                            komut2.ExecuteNonQuery();
                            SqlCommand komut3 = new SqlCommand("update Kitap set stoksayisi=stoksayisi+'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet",baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap(lar) emanet edildi.");
                        daset.Tables["sepet"].Clear();
                        sepetListele();
                        txt_tc.Text = "";
                        lbl_kitapsayı.Text = "";
                        kitapsayisi();
                        lbl_kayıtlıkitapsayı.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Önce üye ismi seçmeniz gerekir!", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz!","Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir!","Uyarı!");
            }
          
        }

        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_sayfasayısı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_kitapsayısı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_adsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_kitapadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_yazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txt_yayınevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }


    }
}
