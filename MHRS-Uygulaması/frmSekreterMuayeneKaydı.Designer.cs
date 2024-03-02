namespace ailehekimidonemproje
{
    partial class frmSekreterMuayeneKaydı
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMuayeneEkleBarkodNo = new System.Windows.Forms.TextBox();
            this.txtMuayeneEkleTC = new System.Windows.Forms.TextBox();
            this.txtMuayeneEkleSikayet = new System.Windows.Forms.TextBox();
            this.txtMuayeneEkleTedavi = new System.Windows.Forms.TextBox();
            this.txtMuayeneEkleTarih = new System.Windows.Forms.TextBox();
            this.btnMuayeneKayıtEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(185, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta TC :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastanın Şikayeti :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(122, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Önerilen Tedavi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(123, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Muayene Tarihi :";
            // 
            // txtMuayeneEkleBarkodNo
            // 
            this.txtMuayeneEkleBarkodNo.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMuayeneEkleBarkodNo.Location = new System.Drawing.Point(334, 107);
            this.txtMuayeneEkleBarkodNo.Name = "txtMuayeneEkleBarkodNo";
            this.txtMuayeneEkleBarkodNo.Size = new System.Drawing.Size(204, 27);
            this.txtMuayeneEkleBarkodNo.TabIndex = 5;
            // 
            // txtMuayeneEkleTC
            // 
            this.txtMuayeneEkleTC.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMuayeneEkleTC.Location = new System.Drawing.Point(334, 147);
            this.txtMuayeneEkleTC.Name = "txtMuayeneEkleTC";
            this.txtMuayeneEkleTC.Size = new System.Drawing.Size(204, 27);
            this.txtMuayeneEkleTC.TabIndex = 6;
            // 
            // txtMuayeneEkleSikayet
            // 
            this.txtMuayeneEkleSikayet.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMuayeneEkleSikayet.Location = new System.Drawing.Point(334, 189);
            this.txtMuayeneEkleSikayet.Name = "txtMuayeneEkleSikayet";
            this.txtMuayeneEkleSikayet.Size = new System.Drawing.Size(204, 27);
            this.txtMuayeneEkleSikayet.TabIndex = 7;
            // 
            // txtMuayeneEkleTedavi
            // 
            this.txtMuayeneEkleTedavi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMuayeneEkleTedavi.Location = new System.Drawing.Point(334, 281);
            this.txtMuayeneEkleTedavi.Name = "txtMuayeneEkleTedavi";
            this.txtMuayeneEkleTedavi.Size = new System.Drawing.Size(204, 27);
            this.txtMuayeneEkleTedavi.TabIndex = 8;
            // 
            // txtMuayeneEkleTarih
            // 
            this.txtMuayeneEkleTarih.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMuayeneEkleTarih.Location = new System.Drawing.Point(334, 236);
            this.txtMuayeneEkleTarih.Name = "txtMuayeneEkleTarih";
            this.txtMuayeneEkleTarih.Size = new System.Drawing.Size(204, 27);
            this.txtMuayeneEkleTarih.TabIndex = 9;
            // 
            // btnMuayeneKayıtEkle
            // 
            this.btnMuayeneKayıtEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMuayeneKayıtEkle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayeneKayıtEkle.Location = new System.Drawing.Point(334, 341);
            this.btnMuayeneKayıtEkle.Name = "btnMuayeneKayıtEkle";
            this.btnMuayeneKayıtEkle.Size = new System.Drawing.Size(204, 55);
            this.btnMuayeneKayıtEkle.TabIndex = 10;
            this.btnMuayeneKayıtEkle.Text = "KAYIT EKLE";
            this.btnMuayeneKayıtEkle.UseVisualStyleBackColor = false;
            this.btnMuayeneKayıtEkle.Click += new System.EventHandler(this.btnMuayeneKayıtEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(721, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "MUAYENESİNİ KAYDETMEK İSTEDİĞİNİZ KİŞİNİN BİLGİLERİNİ GİRİNİZ";
            // 
            // frmSekreterMuayeneKaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMuayeneKayıtEkle);
            this.Controls.Add(this.txtMuayeneEkleTarih);
            this.Controls.Add(this.txtMuayeneEkleTedavi);
            this.Controls.Add(this.txtMuayeneEkleSikayet);
            this.Controls.Add(this.txtMuayeneEkleTC);
            this.Controls.Add(this.txtMuayeneEkleBarkodNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSekreterMuayeneKaydı";
            this.Text = "MUAYENE KAYDI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMuayeneEkleBarkodNo;
        private System.Windows.Forms.TextBox txtMuayeneEkleTC;
        private System.Windows.Forms.TextBox txtMuayeneEkleSikayet;
        private System.Windows.Forms.TextBox txtMuayeneEkleTedavi;
        private System.Windows.Forms.TextBox txtMuayeneEkleTarih;
        private System.Windows.Forms.Button btnMuayeneKayıtEkle;
        private System.Windows.Forms.Label label6;
    }
}