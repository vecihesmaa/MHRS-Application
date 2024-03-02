namespace ailehekimidonemproje
{
    partial class frmHataninIlaclariniGoruntule
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
            this.lblilaclariGoruntule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblilaclariGoruntule
            // 
            this.lblilaclariGoruntule.AutoSize = true;
            this.lblilaclariGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilaclariGoruntule.Location = new System.Drawing.Point(94, 183);
            this.lblilaclariGoruntule.Name = "lblilaclariGoruntule";
            this.lblilaclariGoruntule.Size = new System.Drawing.Size(598, 32);
            this.lblilaclariGoruntule.TabIndex = 0;
            this.lblilaclariGoruntule.Text = "HASTANIN GÖRÜNTÜLENECEK İLAÇLARI";
            // 
            // frmHataninIlaclariniGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblilaclariGoruntule);
            this.Name = "frmHataninIlaclariniGoruntule";
            this.Text = "HASTANIN İLAÇLARINI GÖRÜNTÜLE";
            this.Load += new System.EventHandler(this.frmHataninIlaclariniGoruntule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblilaclariGoruntule;
    }
}