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
    public partial class frmYeniReceteEkle : Form
    {
        public frmYeniReceteEkle()
        {
            InitializeComponent();
        }
        databasebaglanti bgl = new databasebaglanti();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReceteEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("insert into tbl_receteekle (barkodno,ilacadi,ilacadet,hasatadsoyad,doktoradsoyad,tarih,tani) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.conn());
            komut.Parameters.AddWithValue("@p1", NpgsqlDbType.Text).Value = Convert.ToInt32(txtReceteBarkodNo.Text);
            komut.Parameters.AddWithValue("@p2", NpgsqlDbType.Text).Value = txtReceteIlacAdi.Text;
            komut.Parameters.AddWithValue("@p3", NpgsqlDbType.Text).Value = Convert.ToInt32(txtReceteIlacAdet.Text);
            komut.Parameters.AddWithValue("@p4", NpgsqlDbType.Text).Value = txtHastaAdSoyad.Text;
            komut.Parameters.AddWithValue("@p5", NpgsqlDbType.Text).Value = txtDoktorAdSoyad.Text;
            komut.Parameters.AddWithValue("@p6", NpgsqlDbType.Text).Value = Convert.ToInt32(txtReceteTarih.Text);
            komut.Parameters.AddWithValue("@p7", NpgsqlDbType.Text).Value = txtReceteTani.Text;
            komut.ExecuteNonQuery();
            bgl.conn().Close();
            MessageBox.Show("Reçete Kaydınız Sisteme İşlenmiştir.");
        }
    }
}
