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
    public partial class Fadmin : Form
    {
        public Fadmin()
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

        private void Fadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Fkgiris girisedonus = new Fkgiris();
            girisedonus.ShowDialog();
           
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            Femanetkitapiade Emanetİade = new Femanetkitapiade();
            Emanetİade.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Fdefault Fdefaultgecis = new Fdefault();
            Fdefaultgecis.ShowDialog();
        }

        private void Fadmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_kitaplistele_Click(object sender, EventArgs e)
        {
            Fkitaplistele Fkitaplistele = new Fkitaplistele();
            Fkitaplistele.ShowDialog();
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

        private void btnSıralama_Click(object sender, EventArgs e)
        {
            Fsıralama sıralama = new Fsıralama();
            sıralama.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Fgrafik Grafik = new Fgrafik();
            Grafik.ShowDialog();
        }
    }
}
