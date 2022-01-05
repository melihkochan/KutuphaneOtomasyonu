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
    public partial class Femanetkitaplisteleme : Form
    {
        public Femanetkitaplisteleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4O7UO30;Initial Catalog=Proje;Integrated Security=True");
        DataSet daset = new DataSet();

        private void EmanetKitapListeleme()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplarr", baglanti);
            adtr.Fill(daset, "EmanetKitaplarr");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplarr"];
            baglanti.Close();
        }
        private void Femanetkitaplisteleme_Load(object sender, EventArgs e)
        {
            EmanetKitapListeleme();
            comboBox1.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplarr"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                EmanetKitapListeleme();
            }
            else if (comboBox1.SelectedIndex==1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplarr where '" + DateTime.Now.ToShortDateString()+ "'>iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplarr");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplarr"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplarr where '" + DateTime.Now.ToShortDateString() + "'<= iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplarr");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplarr"];
                baglanti.Close();
            }
        }
    }
}
