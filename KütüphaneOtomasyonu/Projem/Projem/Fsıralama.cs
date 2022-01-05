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
    public partial class Fsıralama : Form
    {
        public Fsıralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4O7UO30;Initial Catalog=Proje;Integrated Security=True");
        DataSet daset = new DataSet();
       
        private void Fsıralama_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye order by okukitapsayisi desc", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
            lbl_ençok.Text = "";
          
            lbl_ençok.Text = daset.Tables["Uye"].Rows[0]["adsoyad"].ToString();
            lbl_ençok.Text += daset.Tables["Uye"].Rows[0]["okukitapsayisi"].ToString();
            

        }
    }
}
