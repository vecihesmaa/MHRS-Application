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
    public partial class frmSekreterMenu : Form
    {
        public frmSekreterMenu()
        {
            InitializeComponent();
        }

        private void btnHastaKaydiEkle_Click(object sender, EventArgs e)
        {
            frmSekreterHastaKaydiEkle frmHastaEkle= new frmSekreterHastaKaydiEkle();
            frmHastaEkle.Show();
        }

        private void btnMuayeneKaydiEkle_Click(object sender, EventArgs e)
        {
            frmSekreterMuayeneKaydı frmSekreterMuayeneKaydı=new frmSekreterMuayeneKaydı();
            frmSekreterMuayeneKaydı.Show(); 
        }
    }
}
