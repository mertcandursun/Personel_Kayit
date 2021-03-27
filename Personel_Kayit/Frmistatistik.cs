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

        }
    }
}
