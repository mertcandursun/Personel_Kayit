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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BELVBNK\\SQLEXPRESS;Initial Catalog=PersonelVeritabani;Integrated Security=True");
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand perSayiCek = new SqlCommand("select count(*) From Tbl_Personel", baglanti);
            SqlDataReader oku1 = perSayiCek.ExecuteReader();
            while (oku1.Read())
            {
                lblTopPer.Text = oku1[0].ToString();
            }
            
            baglanti.Close();

            //Evli personelleri çekmek

            baglanti.Open();
            SqlCommand evliPerCek = new SqlCommand("select count(*) From Tbl_Personel where PerDurum = 1", baglanti);
            SqlDataReader oku2 = evliPerCek.ExecuteReader();

            while (oku2.Read())
            {
                lblEvliPer.Text = oku2[0].ToString();
            }
            baglanti.Close();

            //Bekar personelleri çekmek

            baglanti.Open();
            SqlCommand bekarPerCek = new SqlCommand("select count(*) From Tbl_Personel where PerDurum = 0", baglanti);
            SqlDataReader oku3 = bekarPerCek.ExecuteReader();

            while (oku3.Read())
            {
                lblBekarPer.Text = oku3[0].ToString();
            }
            baglanti.Close();

            //Şehir sayısı çekmek

            baglanti.Open();
            SqlCommand sehirSayiCek = new SqlCommand("select count(distinct(PerSehir)) From Tbl_Personel", baglanti);
            SqlDataReader oku4 = sehirSayiCek.ExecuteReader();

            while (oku4.Read())
            {
                lblSehirler.Text = oku4[0].ToString();
            }
            baglanti.Close();


        }
    }
}
