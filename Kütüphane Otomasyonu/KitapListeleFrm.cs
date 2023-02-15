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
    public partial class KitapListeleFrm : Form
    {
        public KitapListeleFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True"); // bağlantı cümlesi
        DataSet daset = new DataSet();
        private void KitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void KitapListeleFrm_Load(object sender, EventArgs e)
        {
            KitapListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;

            dialog = MessageBox.Show("Bu Kaydı Silmek İstediğinden Emin Misin?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Kitap WHERE barkodNo=@barkodNo", baglanti);
                komut.Parameters.AddWithValue("@barkodNo", dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı.");
                daset.Tables["Kitap"].Clear();
                KitapListele();

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand
            ("UPDATE Kitap SET kitapAdi=@kitapAdi, yazari=@yazari, yayinevi=@yayinevi, sayfaSayisi= @sayfaSayisi" +
            ", turu=@turu, stokSayisi= @stokSayisi, rafNo= @rafNo, aciklama=@aciklama, kayitTarihi=@kayitTarihi WHERE barkodNo=@barkodNo"
                , baglanti);
            komut.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
            komut.Parameters.AddWithValue("@sayfaSayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboTuru.Text);
            komut.Parameters.AddWithValue("@stokSayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            komut.Parameters.AddWithValue("@kayitTarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı.");

            daset.Tables["Kitap"].Clear();
            KitapListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Kitap WHERE barkodNo LIKE '%" + txtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Kitap WHERE barkodNo LIKE '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapAdi"].ToString();
                txtYazar.Text = read["yazari"].ToString();
                txtYayinEvi.Text = read["yayinEvi"].ToString();
                txtSayfaSayisi.Text = read["sayfaSayisi"].ToString();
                comboTuru.Text = read["turu"].ToString();
                txtStokSayisi.Text = read["stokSayisi"].ToString();
                txtRafNo.Text = read["rafNo"].ToString();
                txtAciklama.Text = read["aciklama"].ToString();
            }


            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
