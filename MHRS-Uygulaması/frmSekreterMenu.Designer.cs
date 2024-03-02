namespace ailehekimidonemproje
{
    partial class frmSekreterMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterMenu));
            this.btnHastaKaydiEkle = new System.Windows.Forms.Button();
            this.btnMuayeneKaydiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaKaydiEkle
            // 
            this.btnHastaKaydiEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHastaKaydiEkle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKaydiEkle.Location = new System.Drawing.Point(308, 173);
            this.btnHastaKaydiEkle.Name = "btnHastaKaydiEkle";
            this.btnHastaKaydiEkle.Size = new System.Drawing.Size(296, 87);
            this.btnHastaKaydiEkle.TabIndex = 0;
            this.btnHastaKaydiEkle.Text = "HASTA KAYDI EKLE";
            this.btnHastaKaydiEkle.UseVisualStyleBackColor = false;
            this.btnHastaKaydiEkle.Click += new System.EventHandler(this.btnHastaKaydiEkle_Click);
            // 
            // btnMuayeneKaydiEkle
            // 
            this.btnMuayeneKaydiEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMuayeneKaydiEkle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayeneKaydiEkle.Location = new System.Drawing.Point(308, 282);
            this.btnMuayeneKaydiEkle.Name = "btnMuayeneKaydiEkle";
            this.btnMuayeneKaydiEkle.Size = new System.Drawing.Size(296, 87);
            this.btnMuayeneKaydiEkle.TabIndex = 1;
            this.btnMuayeneKaydiEkle.Text = "MUAYENE KAYDI EKLE";
            this.btnMuayeneKaydiEkle.UseVisualStyleBackColor = false;
            this.btnMuayeneKaydiEkle.Click += new System.EventHandler(this.btnMuayeneKaydiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(106, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmSekreterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMuayeneKaydiEkle);
            this.Controls.Add(this.btnHastaKaydiEkle);
            this.Name = "frmSekreterMenu";
            this.Text = "SEKRETER MENÜ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaKaydiEkle;
        private System.Windows.Forms.Button btnMuayeneKaydiEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}