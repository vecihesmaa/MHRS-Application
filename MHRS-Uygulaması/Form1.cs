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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yENİREÇETEEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeniReceteEkle frmYeniReceteEkle = new frmYeniReceteEkle();  
            frmYeniReceteEkle.Show();
        }

        private void hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaIlacGoruntuleKod frmHastaIlacGoruntuleKod = new frmHastaIlacGoruntuleKod(); 
            frmHastaIlacGoruntuleKod.Show();    
        }

        private void yAPILANTÜMMUAYENELERToolStripMenuItem_Click(object sender, EventArgs e)
        {      frmYapilanTumMuayeneleriGoruntule frmYapilanMuayeneler=new frmYapilanTumMuayeneleriGoruntule();
               frmYapilanMuayeneler.Show(); 
           
        }

        private void gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGecmisReceteleriGoruntule frmGecmisReceteGoruntule = new frmGecmisReceteleriGoruntule();
            frmGecmisReceteGoruntule.Show();
        }

        private void dENEMEKISITLIREÇETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKısıtlıReçeteEkle frmKısıtlıReçeteEkle=new frmKısıtlıReçeteEkle();   
            frmKısıtlıReçeteEkle.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
