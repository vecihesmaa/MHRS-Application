﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSekreterMenu frmSekreterMenu = new frmSekreterMenu();    
            frmSekreterMenu.Show();
        }
    }
}
