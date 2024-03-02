using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ailehekimidonemproje
{
    public partial class frmHataninIlaclariniGoruntule : Form
    {
        public frmHataninIlaclariniGoruntule()
        {
            InitializeComponent();
        }
        public string hastaadsoyad;
        databasebaglanti bgl = new databasebaglanti();
        private void frmHataninIlaclariniGoruntule_Load(object sender, EventArgs e)
        {
            lblilaclariGoruntule.Text = hastaadsoyad;
            NpgsqlCommand komut = new NpgsqlCommand("select hastaadsoyad,ilacadi from tbl_hastaninilaclarinigoruntule where hastaadsoyad=@p1", bgl.conn());
            komut.Parameters.AddWithValue("@p1", hastaadsoyad);
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblilaclariGoruntule.Text = dr[0] + " " +"İLAÇLARI"+" "+"|"+" "+ dr[1];
            }
            komut.Dispose();
            bgl.conn().Close();
        }
    }
}
