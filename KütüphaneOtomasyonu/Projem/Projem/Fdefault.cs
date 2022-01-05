using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    public partial class Fdefault : Form
    {
        public Fdefault()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            Füyeekle uyeekle = new Füyeekle();
            uyeekle.ShowDialog();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            Füyelisteleme üyelistele = new Füyelisteleme();
            üyelistele.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Fkitapekle kitapekle = new Fkitapekle();
            kitapekle.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            Fkitaplistele kitaplistele = new Fkitaplistele();
            kitaplistele.ShowDialog();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            Femanetislem EmanetVer = new Femanetislem();
            EmanetVer.ShowDialog();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            Femanetkitaplisteleme EmanetListele = new Femanetkitaplisteleme();
            EmanetListele.ShowDialog();
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            Femanetkitapiade Emanetİade = new Femanetkitapiade();
            Emanetİade.ShowDialog();
        }

  
        private void Fdefault_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSıralama_Click_1(object sender, EventArgs e)
        {
            Fsıralama sıralama = new Fsıralama();
            sıralama.ShowDialog();
        }

        private void btnGrafik_Click_1(object sender, EventArgs e)
        {
            Fgrafik Grafik = new Fgrafik();
            Grafik.ShowDialog();
        }

        private void Fdefault_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Fdefault_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Fkgiris girisedonus = new Fkgiris();
            girisedonus.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
