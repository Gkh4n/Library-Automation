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
    public partial class EmanetKitapIadeFrm : Form
    {
        public EmanetKitapIadeFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True"); // bağlantı cümlesi
        DataSet daset = new DataSet();


        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmanetKitapIadeFrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM EmanetKitaplar WHERE tc LIKE '%"+txtTCAra.Text+"%'",baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();

            if (txtTCAra.Text=="")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
         }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM EmanetKitaplar WHERE tc=@tc",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("UPDATE Kitap SET stokSayisi= stokSayisi + '"
                +dataGridView1.CurrentRow.Cells["kitapSayisi"].Value.ToString()+"' WHERE barkodNo=@barkodNo", baglanti);
            komut2.Parameters.AddWithValue("@barkodNo", dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) İade Edildi.");
            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }
    }
}
