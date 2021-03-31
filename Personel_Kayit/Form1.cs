using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BELVBNK\\SQLEXPRESS;Initial Catalog=PersonelVeritabani;Integrated Security=True");
        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMeslek.Text = "";
            mskMaas.Text = "";
            cmbSehir.SelectedIndex = 0;
            radioEvli.Checked = false;
            radioBekar.Checked = false;
            txtAd.Focus();
        }

        void ListeGetir()
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeritabaniDataSet.Tbl_Personel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.tbl_PersonelTableAdapter.Fill(this.personelVeritabaniDataSet.Tbl_Personel);
            ListeGetir();
            cmbSehir.SelectedIndex = 0;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //this.tbl_PersonelTableAdapter.Fill(this.personelVeritabaniDataSet.Tbl_Personel);
            ListeGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaydetkomut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            kaydetkomut.Parameters.AddWithValue("@p1", txtAd.Text);
            kaydetkomut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            kaydetkomut.Parameters.AddWithValue("@p3", cmbSehir.SelectedItem);
            kaydetkomut.Parameters.AddWithValue("@p4", mskMaas.Text);
            kaydetkomut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            kaydetkomut.Parameters.AddWithValue("p6", label1.Text);
            if (txtAd.Text == " ")
            {
                txtAd.Text = "null";
            }
            if (txtSoyad.Text == " ")
            {
                txtSoyad.Text = "null";
            }
            if (txtMeslek.Text == " ")
            {
                txtMeslek.Text = "null";
            }
            if (mskMaas.Text == " ")
            {
                mskMaas.Text = "null";
            }
            kaydetkomut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi");
        }

        private void radioEvli_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "True";
        }

        private void radioBekar_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "False";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "True")
            {
                radioEvli.Checked = true;
            }
            if (label2.Text == "False")
            {
                radioBekar.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult yesorno = new DialogResult();
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where PerID = @perid",baglanti);
            komutsil.Parameters.AddWithValue("@perid", txtID.Text);
            yesorno = MessageBox.Show("Kişi siliniyor emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yesorno == DialogResult.Yes)
            {
                komutsil.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarı ile silindi !", "Bilgi", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt silme iptal edildi !");
            }
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set PerAd = @u1, PerSoyad = @u2, PerSehir = @u3, PerMaas = @u4, PerDurum = @u5, PerMeslek = @u6 where PerID = @u7",baglanti);
            komutguncelle.Parameters.AddWithValue("@u1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@u2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@u3", cmbSehir.SelectedItem);
            komutguncelle.Parameters.AddWithValue("@u4", mskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@u5", label1.Text);
            komutguncelle.Parameters.AddWithValue("@u6", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@u7", txtID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel güncellendi");
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Frmistatistik istatistik = new Frmistatistik();
            istatistik.Show();
        }
    }
}
