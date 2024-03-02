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
    public partial class frmYapilanTumMuayeneleriGoruntule : Form
    {
        public frmYapilanTumMuayeneleriGoruntule()
        {
            InitializeComponent();
        }
        databasebaglanti bgl = new databasebaglanti();
        private void btnMuayeneGoster_Click(object sender, EventArgs e)
        {
            YapilanMuayeneGoster.Items.Clear();
            NpgsqlCommand komut = new NpgsqlCommand("Select *from tbl_poliklinikkayit", bgl.conn());
            NpgsqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                YapilanMuayeneGoster.Items.Add(reader[0] + "     " + reader[1] + "          " + reader[2] + "         " + reader[3] + "         " + reader[4] + "          " + reader[5] + "        " + reader[6]);
            }
            bgl.conn().Close();

        }
    }
}
