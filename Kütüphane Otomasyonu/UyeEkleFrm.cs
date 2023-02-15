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
    public partial class UyeEkleFrm : Form
    {
        public UyeEkleFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True"); // bağlantı cümlesi


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close(); // iptale basıldığnda ekranı kapat
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if (txtTC.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand
                    ("INSERT INTO Uye(tc,adSoyad,yas,cinsiyet,telefon,adres,email,okuKitapSayisi) VALUES(@tc,@adSoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okuKitapSayisi)"
                    , baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@okuKitapSayisi", txtOkunanSayi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üye Kaydı Başarıyla Tamamlandı.");

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtOkunanSayi)
                        {
                            item.Text = "";
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Tc Boş Bırakılamaz!","Uyarı");
            }
        }

        private void UyeEkleFrm_Load(object sender, EventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtOkunanSayi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
