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
    public partial class frmHastaIlacGoruntuleKod : Form
    {
        public frmHastaIlacGoruntuleKod()
        {
            InitializeComponent();
        }

        private void frmHastaIlacGoruntuleKod_Load(object sender, EventArgs e)
        {
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            frmHataninIlaclariniGoruntule fr=new frmHataninIlaclariniGoruntule();
            fr.hastaadsoyad = txtIlacHastaAdSoyad.Text;
            fr.Show();
        }
    }
}
