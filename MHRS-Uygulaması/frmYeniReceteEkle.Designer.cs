namespace ailehekimidonemproje
{
    partial class frmYeniReceteEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReceteBarkodNo = new System.Windows.Forms.TextBox();
            this.txtReceteIlacAdi = new System.Windows.Forms.TextBox();
            this.txtReceteIlacTipi = new System.Windows.Forms.TextBox();
            this.txtReceteIlacAdet = new System.Windows.Forms.TextBox();
            this.btnReceteEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceteTarih = new System.Windows.Forms.TextBox();
            this.txtDoktorAdSoyad = new System.Windows.Forms.TextBox();
            this.txtHastaAdSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReceteTani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlaç Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlaç Tipi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "İlaç Adet :";
            // 
            // txtReceteBarkodNo
            // 
            this.txtReceteBarkodNo.Location = new System.Drawing.Point(265, 153);
            this.txtReceteBarkodNo.Name = "txtReceteBarkodNo";
            this.txtReceteBarkodNo.Size = new System.Drawing.Size(100, 22);
            this.txtReceteBarkodNo.TabIndex = 4;
            // 
            // txtReceteIlacAdi
            // 
            this.txtReceteIlacAdi.Location = new System.Drawing.Point(265, 184);
            this.txtReceteIlacAdi.Name = "txtReceteIlacAdi";
            this.txtReceteIlacAdi.Size = new System.Drawing.Size(100, 22);
            this.txtReceteIlacAdi.TabIndex = 5;
            this.txtReceteIlacAdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtReceteIlacTipi
            // 
            this.txtReceteIlacTipi.Location = new System.Drawing.Point(265, 216);
            this.txtReceteIlacTipi.Name = "txtReceteIlacTipi";
            this.txtReceteIlacTipi.Size = new System.Drawing.Size(100, 22);
            this.txtReceteIlacTipi.TabIndex = 6;
            // 
            // txtReceteIlacAdet
            // 
            this.txtReceteIlacAdet.Location = new System.Drawing.Point(265, 251);
            this.txtReceteIlacAdet.Name = "txtReceteIlacAdet";
            this.txtReceteIlacAdet.Size = new System.Drawing.Size(100, 22);
            this.txtReceteIlacAdet.TabIndex = 7;
            // 
            // btnReceteEkle
            // 
            this.btnReceteEkle.Location = new System.Drawing.Point(265, 315);
            this.btnReceteEkle.Name = "btnReceteEkle";
            this.btnReceteEkle.Size = new System.Drawing.Size(100, 50);
            this.btnReceteEkle.TabIndex = 8;
            this.btnReceteEkle.Text = "EKLE";
            this.btnReceteEkle.UseVisualStyleBackColor = true;
            this.btnReceteEkle.Click += new System.EventHandler(this.btnReceteEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasta Adı Soyadı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Doktor Adı Soyadı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tarih :";
            // 
            // txtReceteTarih
            // 
            this.txtReceteTarih.Location = new System.Drawing.Point(265, 115);
            this.txtReceteTarih.Name = "txtReceteTarih";
            this.txtReceteTarih.Size = new System.Drawing.Size(100, 22);
            this.txtReceteTarih.TabIndex = 12;
            // 
            // txtDoktorAdSoyad
            // 
            this.txtDoktorAdSoyad.Location = new System.Drawing.Point(265, 76);
            this.txtDoktorAdSoyad.Name = "txtDoktorAdSoyad";
            this.txtDoktorAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtDoktorAdSoyad.TabIndex = 13;
            // 
            // txtHastaAdSoyad
            // 
            this.txtHastaAdSoyad.Location = new System.Drawing.Point(265, 48);
            this.txtHastaAdSoyad.Name = "txtHastaAdSoyad";
            this.txtHastaAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtHastaAdSoyad.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tanı :";
            // 
            // txtReceteTani
            // 
            this.txtReceteTani.Location = new System.Drawing.Point(490, 48);
            this.txtReceteTani.Name = "txtReceteTani";
            this.txtReceteTani.Size = new System.Drawing.Size(121, 22);
            this.txtReceteTani.TabIndex = 16;
            // 
            // frmYeniReceteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReceteTani);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHastaAdSoyad);
            this.Controls.Add(this.txtDoktorAdSoyad);
            this.Controls.Add(this.txtReceteTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReceteEkle);
            this.Controls.Add(this.txtReceteIlacAdet);
            this.Controls.Add(this.txtReceteIlacTipi);
            this.Controls.Add(this.txtReceteIlacAdi);
            this.Controls.Add(this.txtReceteBarkodNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmYeniReceteEkle";
            this.Text = "YENİ REÇETE EKLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReceteBarkodNo;
        private System.Windows.Forms.TextBox txtReceteIlacAdi;
        private System.Windows.Forms.TextBox txtReceteIlacTipi;
        private System.Windows.Forms.TextBox txtReceteIlacAdet;
        private System.Windows.Forms.Button btnReceteEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReceteTarih;
        private System.Windows.Forms.TextBox txtDoktorAdSoyad;
        private System.Windows.Forms.TextBox txtHastaAdSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReceteTani;
    }
}