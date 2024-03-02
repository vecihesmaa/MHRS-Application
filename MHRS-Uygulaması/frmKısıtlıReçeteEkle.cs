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
    public partial class frmKısıtlıReçeteEkle : Form
    {
        public frmKısıtlıReçeteEkle()
        {
            InitializeComponent();
        }
        databasebaglanti bgl = new databasebaglanti();
        private void btnKisitliReceteEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("insert into tbl_kisitlireceteekle (sırano,ilacadi,ilacadet,ilactipi,hastaadsoyad,hastatc,tarih,tani) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.conn());
            komut.Parameters.AddWithValue("@p1", NpgsqlDbType.Text).Value = Convert.ToInt32(txtKisitliReceteSiraNo.Text);
            komut.Parameters.AddWithValue("@p2", NpgsqlDbType.Text).Value = txtKisitliReceteIlacAdi.Text;
            komut.Parameters.AddWithValue("@p3", NpgsqlDbType.Text).Value = Convert.ToInt32(txtKisitliReceteIlacAdet.Text);
            komut.Parameters.AddWithValue("@p4", NpgsqlDbType.Text).Value = txtKisitliReceteIlacTipi.Text;
            komut.Parameters.AddWithValue("@p5", NpgsqlDbType.Text).Value = txtKisitliHastaAdSoyad.Text;
            komut.Parameters.AddWithValue("@p6", NpgsqlDbType.Text).Value = Convert.ToInt64(txtKisitliHastaTc.Text);
            komut.Parameters.AddWithValue("@p7", NpgsqlDbType.Text).Value = Convert.ToInt32(txtKisitliReceteTarih.Text);
            komut.Parameters.AddWithValue("@p8", NpgsqlDbType.Text).Value = txtKisitliReceteTani.Text;
            komut.ExecuteNonQuery();
            bgl.conn().Close();

            MessageBox.Show("Reçete Kaydınız Sisteme İşlenmiştir.");

        }
    }
}
