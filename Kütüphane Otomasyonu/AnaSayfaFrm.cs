using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class AnaSayfaFrm : Form
    {
        public AnaSayfaFrm()
        {
            InitializeComponent();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListelemeFrm uyeListe = new UyeListelemeFrm();
            uyeListe.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListeleFrm kitapListele = new KitapListeleFrm();
            kitapListele.ShowDialog();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListeleFrm listele = new EmanetKitapListeleFrm();
            listele.ShowDialog();
        }

        private void btnEmanetIade_Click(object sender, EventArgs e)
        {
            EmanetKitapIadeFrm emanetKitapIade = new EmanetKitapIadeFrm();
            emanetKitapIade.ShowDialog();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkleFrm uyeEkle = new UyeEkleFrm();
            uyeEkle.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleFrm kitapEkle = new KitapEkleFrm();
            kitapEkle.ShowDialog();

        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVerFrm emanetKitapVer = new EmanetKitapVerFrm();
            emanetKitapVer.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {

        }

        private void AnaSayfaFrm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
