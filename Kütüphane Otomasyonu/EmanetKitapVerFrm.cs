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
    public partial class EmanetKitapVerFrm : Form
    {
        public EmanetKitapVerFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True"); // bağlantı cümlesi
        DataSet daset = new DataSet();
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Sepet",baglanti);
            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text !="" && txtTcAra.Text !="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Sepet(barkodNo,kitapAdi,yazari,yayinevi,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi) VALUES(@barkodNo,@kitapAdi,@yazari,@yayinevi,@sayfaSayisi,@kitapSayisi,@teslimTarihi,@iadeTarihi)", baglanti);

                komut.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfaSayisi", txtSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@kitapSayisi", int.Parse(txtKitapSayisi.Text));
                komut.Parameters.AddWithValue("@teslimTarihi", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@iadeTarihi", dateTimePicker2.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap(lar) sepete eklendi.", "Kitap Ekleme İşleme");
                daset.Tables["Sepet"].Clear();
                sepetListele();
                lblKitapSayi.Text = "";
                kitapSayisi();


                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayisi)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Üye Tc ve Kitap Barkod No Boş Bırakılamaz!", "Uyarı");
            }
        }


        private void kitapSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(kitapSayisi) FROM Sepet",baglanti);
            lblKitapSayi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void EmanetKitapVerFrm_Load(object sender, EventArgs e)
        {
            sepetListele();
            kitapSayisi();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Uye WHERE tc LIKE '"+txtTcAra.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtAdSoyad.Text = read["adSoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(kitapSayisi) FROM EmanetKitaplar WHERE tc= '"+txtTcAra.Text+"'",baglanti);
            lblKayitliKitapSayi.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txtTcAra.Text =="")
            {
                foreach (Control item in grpUyeBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblKayitliKitapSayi.Text = "";
                    }

                    
                }
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Kitap WHERE barkodNo LIKE '"+txtBarkodNo.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapAdi"].ToString();
                txtYazari.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfaSayisi"].ToString();
                
            }
            baglanti.Close();

            if (txtBarkodNo.Text=="")
            {
                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayisi)
                        {
                            item.Text = "";
                        }
                    }
                }
            }


            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblKitapSayi.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Sepet WHERE barkodNo LIKE '"
                    + dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silme İşlemi");
                daset.Tables["Sepet"].Clear();
                sepetListele();
                lblKayitliKitapSayi.Text = "";
                kitapSayisi();
            }
            else
            {
                MessageBox.Show("Silinecek Herhangi Bir Kitap Bulunamamaktadır.", "Uyarı");
            }
            

        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayi.Text!="")
            {
                if (lblKayitliKitapSayi.Text=="" && int.Parse(lblKitapSayi.Text) <=3 || lblKayitliKitapSayi.Text!="" && int.Parse(lblKayitliKitapSayi.Text) + int.Parse(lblKitapSayi.Text)<=3)
                {
                    if (txtTcAra.Text!="" && txtAdSoyad.Text !="" && txtYas.Text!="" && txtTelefon.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("INSERT INTO EmanetKitaplar(tc,adSoyad,yas,telefon,barkodNo,kitapAdi,yazari,yayinevi,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi) VALUES(@tc,@adSoyad,@yas,@telefon,@barkodNo,@kitapAdi,@yazari,@yayinevi,@sayfaSayisi,@kitapSayisi,@teslimTarihi,@iadeTarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc", txtTcAra.Text);
                            komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@yas", txtYas.Text);
                            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                            komut.Parameters.AddWithValue("@barkodNo", dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapAdi", dataGridView1.Rows[i].Cells["kitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("@yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@sayfaSayisi", dataGridView1.Rows[i].Cells["sayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapSayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("@teslimTarihi", dataGridView1.Rows[i].Cells["teslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadeTarihi", dataGridView1.Rows[i].Cells["iadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();

                            SqlCommand komut2 = new SqlCommand("UPDATE Uye SET okuKitapSayisi = okuKitapSayisi + '"+int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString())+"' WHERE tc = '"+txtTcAra.Text+"'",baglanti);
                            komut2.ExecuteNonQuery();

                            SqlCommand komut3 = new SqlCommand("UPDATE Kitap SET stokSayisi=stokSayisi- '" + int.Parse(dataGridView1.Rows[i].Cells["kitapSayisi"].Value.ToString()) + "' WHERE barkodNo = '" + dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString() + "'", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();

                        }

                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("DELETE FROM Sepet",baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap(lar) Emanet Edildi.");
                        daset.Tables["Sepet"].Clear();
                        sepetListele();
                        txtTcAra.Text = "";
                        lblKitapSayi.Text = "";
                        kitapSayisi();
                        lblKayitliKitapSayi.Text = "";
                        // komut satırları
                    }
                    else
                    {
                        MessageBox.Show("Önce Üye İsmi Seçmeniz Gerekir!","Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Emanet Kitap Sayısı 3'ten Fazla Olamaz!", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Önce Sepete Kitap Eklenmelidir.", "Uyarı");
            }
            
            
            
            
            
            
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}








