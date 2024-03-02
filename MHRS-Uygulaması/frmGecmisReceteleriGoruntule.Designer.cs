namespace ailehekimidonemproje
{
    partial class frmGecmisReceteleriGoruntule
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
            this.btnGecmisRecete = new System.Windows.Forms.Button();
            this.GecmisRecete = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGecmisRecete
            // 
            this.btnGecmisRecete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGecmisRecete.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisRecete.Location = new System.Drawing.Point(180, 37);
            this.btnGecmisRecete.Name = "btnGecmisRecete";
            this.btnGecmisRecete.Size = new System.Drawing.Size(459, 64);
            this.btnGecmisRecete.TabIndex = 0;
            this.btnGecmisRecete.Text = "GÖRÜNTÜLE";
            this.btnGecmisRecete.UseVisualStyleBackColor = false;
            this.btnGecmisRecete.Click += new System.EventHandler(this.btnGecmisRecete_Click);
            // 
            // GecmisRecete
            // 
            this.GecmisRecete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GecmisRecete.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GecmisRecete.FormattingEnabled = true;
            this.GecmisRecete.ItemHeight = 21;
            this.GecmisRecete.Location = new System.Drawing.Point(0, 131);
            this.GecmisRecete.Name = "GecmisRecete";
            this.GecmisRecete.Size = new System.Drawing.Size(800, 319);
            this.GecmisRecete.TabIndex = 1;
            // 
            // frmGecmisReceteleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GecmisRecete);
            this.Controls.Add(this.btnGecmisRecete);
            this.Name = "frmGecmisReceteleriGoruntule";
            this.Text = "REÇETELERİ GÖRÜNTÜLE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGecmisRecete;
        private System.Windows.Forms.ListBox GecmisRecete;
    }
}