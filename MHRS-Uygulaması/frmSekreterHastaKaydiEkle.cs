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
    public partial class frmSekreterHastaKaydiEkle : Form
    {
        public frmSekreterHastaKaydiEkle()
        {
            InitializeComponent();
        }
        databasebaglanti bgl = new databasebaglanti();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("insert into tbl_hastaekle (tckimlikno,ad,soyad,dogumyeri,dogumtarihi,yasadigiyer,medenidurumu,adres,telefon) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.conn());
            komut.Parameters.AddWithValue("@p1", NpgsqlDbType.Text).Value = Convert.ToInt64(txtHastaEkleTC.Text);
            komut.Parameters.AddWithValue("@p2", NpgsqlDbType.Text).Value = txtHastaEkleAd.Text;
            komut.Parameters.AddWithValue("@p3", NpgsqlDbType.Text).Value = txtHastaEkleSoyad.Text;
            komut.Parameters.AddWithValue("@p4", NpgsqlDbType.Text).Value = txtHastaEkleDogumYeri.Text;
            komut.Parameters.AddWithValue("@p5", NpgsqlDbType.Text).Value = Convert.ToInt32(txtHastaEkleDogumTarihi.Text);
            komut.Parameters.AddWithValue("@p6", NpgsqlDbType.Text).Value = txtHastaEkleYasadigiYer.Text;
            komut.Parameters.AddWithValue("@p7", NpgsqlDbType.Text).Value = txtHastaEkleMedeniDurum.Text;
            komut.Parameters.AddWithValue("@p8", NpgsqlDbType.Text).Value = txtHastaEkleAdres.Text;
            komut.Parameters.AddWithValue("@p9", NpgsqlDbType.Text).Value = Convert.ToInt64(txtHastaEkleTelefon.Text);
            komut.ExecuteNonQuery();
            bgl.conn().Close();
            MessageBox.Show("Yeni Hasta Kaydınız Sisteme İşlenmiştir.");
        }
    }
}
