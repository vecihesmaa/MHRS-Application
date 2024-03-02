namespace ailehekimidonemproje
{
    partial class frmHastaIlacGoruntuleKod
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
            this.txtIlacHastaAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIlacHastaAdSoyad
            // 
            this.txtIlacHastaAdSoyad.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlacHastaAdSoyad.Location = new System.Drawing.Point(216, 198);
            this.txtIlacHastaAdSoyad.Name = "txtIlacHastaAdSoyad";
            this.txtIlacHastaAdSoyad.Size = new System.Drawing.Size(327, 38);
            this.txtIlacHastaAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlaçlarını Görüntülemek İstediğiniz Hastanın Adını ve Soyadını Giriniz :";
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoruntule.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.Location = new System.Drawing.Point(261, 293);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(224, 45);
            this.btnGoruntule.TabIndex = 2;
            this.btnGoruntule.Text = "GÖRÜNTÜLE";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // frmHastaIlacGoruntuleKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIlacHastaAdSoyad);
            this.Name = "frmHastaIlacGoruntuleKod";
            this.Text = "İLAÇ SORGULAMA";
            this.Load += new System.EventHandler(this.frmHastaIlacGoruntuleKod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIlacHastaAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoruntule;
    }
}