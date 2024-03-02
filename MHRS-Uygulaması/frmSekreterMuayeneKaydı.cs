using Npgsql;
using NpgsqlTypes;
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
    public partial class frmSekreterMuayeneKaydı : Form
    {
        public frmSekreterMuayeneKaydı()
        {
            InitializeComponent();
        }
        databasebaglanti bgl = new databasebaglanti();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMuayeneKayıtEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("insert into tbl_muayenekayit (barkodno,hastatc,muayenetarihi,hastaninsikayeti,onerilentedavi) values (@p1,@p2,@p3,@p4,@p5)", bgl.conn());
            komut.Parameters.AddWithValue("@p1", NpgsqlDbType.Text).Value = Convert.ToInt32(txtMuayeneEkleBarkodNo.Text);
            komut.Parameters.AddWithValue("@p2", NpgsqlDbType.Text).Value = Convert.ToInt64(txtMuayeneEkleTC.Text);
            komut.Parameters.AddWithValue("@p3", NpgsqlDbType.Text).Value = Convert.ToInt32(txtMuayeneEkleTarih.Text);
            komut.Parameters.AddWithValue("@p4", NpgsqlDbType.Text).Value = txtMuayeneEkleSikayet.Text;
            komut.Parameters.AddWithValue("@p5", NpgsqlDbType.Text).Value = txtMuayeneEkleTedavi.Text;
            komut.ExecuteNonQuery();
            bgl.conn().Close();
            MessageBox.Show("Yeni Muayene Kaydınız Sisteme Eklenmiştir.");
        }
    }
}
