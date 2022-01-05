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
    public partial class Femanetkitapiade : Form
    {
        public Femanetkitapiade()
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
        private void Femanetkitapiade_Load(object sender, EventArgs e)
        {
            EmanetKitapListeleme();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplarr"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplarr where tc like '%" + txttcara.Text+"%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplarr"); 
            baglanti.Close();
            if (txttcara.Text=="")
            {
                daset.Tables["EmanetKitaplarr"].Clear();
                EmanetKitapListeleme();
            }
        }

        private void txtbarkodara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplarr"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplarr where barkodno like '%" + txtbarkodara.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplarr");
            baglanti.Close();
            if (txtbarkodara.Text == "")
            {
                daset.Tables["EmanetKitaplarr"].Clear();
                EmanetKitapListeleme();
            }
        }

        private void btnteslim_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplarr where tc=@tc and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=stoksayisi+'"+dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString()+"' where barkodno=@barkodno", baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) iade edildi.");
            daset.Tables["EmanetKitaplarr"].Clear();
            EmanetKitapListeleme();
        }

        private void txttcara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbarkodara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
