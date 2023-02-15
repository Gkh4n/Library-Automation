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

namespace Kütüphane_Otomasyonu
{
    public partial class KitapEkleFrm : Form
    {
        public KitapEkleFrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True"); // bağlantı cümlesi

        private void KitapEkleFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text != "")
            {
                baglanti.Open(); // bağlantıyı aç
                SqlCommand komut = new SqlCommand
                    ("INSERT INTO Kitap(barkodNo,kitapAdi,yazari,yayinevi,sayfaSayisi,turu,stokSayisi,rafNo,aciklama,kayitTarihi) VALUES(@barkodNo,@kitapAdi,@yazari,@yayinevi,@sayfaSayisi,@turu,@stokSayisi,@rafNo,@aciklama,@kayitTarihi)", baglanti);
                komut.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfaSayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@turu", comboTuru.Text);
                komut.Parameters.AddWithValue("@stokSayisi", txtStokSayisi.Text);
                komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.Parameters.AddWithValue("@kayitTarihi", DateTime.Now.ToShortDateString()); // bugünün tarihi
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Kaydı Başarıyla Tamamlandı.");

                foreach (Control item in Controls) // formdaki bütün kontrolleri tarıyoruz
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Kitap Barkod No Boş Bırakılamaz!","Uyarı");
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
