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
    public partial class frmGecmisReceteleriGoruntule : Form
    {
        public frmGecmisReceteleriGoruntule()
        {
            InitializeComponent();
        }
        databasebaglanti bgl = new databasebaglanti();
        private void btnGecmisRecete_Click(object sender, EventArgs e)
        {
            GecmisRecete.Items.Clear();
            NpgsqlCommand komut = new NpgsqlCommand("Select *from tbl_recete order by tarih", bgl.conn());
            NpgsqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                GecmisRecete.Items.Add(reader[0] + "     " + reader[1] + "               " + reader[2] + "             " + reader[3] + "           " + reader[4] + "            " + reader[5]);
            }
            bgl.conn().Close();
        }
    }
}
