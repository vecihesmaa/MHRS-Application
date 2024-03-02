namespace ailehekimidonemproje
{
    partial class frmYapilanTumMuayeneleriGoruntule
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
            this.btnMuayeneGoster = new System.Windows.Forms.Button();
            this.YapilanMuayeneGoster = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMuayeneGoster
            // 
            this.btnMuayeneGoster.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMuayeneGoster.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayeneGoster.Location = new System.Drawing.Point(204, 24);
            this.btnMuayeneGoster.Name = "btnMuayeneGoster";
            this.btnMuayeneGoster.Size = new System.Drawing.Size(377, 60);
            this.btnMuayeneGoster.TabIndex = 0;
            this.btnMuayeneGoster.Text = "GÖSTER";
            this.btnMuayeneGoster.UseVisualStyleBackColor = false;
            this.btnMuayeneGoster.Click += new System.EventHandler(this.btnMuayeneGoster_Click);
            // 
            // YapilanMuayeneGoster
            // 
            this.YapilanMuayeneGoster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.YapilanMuayeneGoster.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YapilanMuayeneGoster.FormattingEnabled = true;
            this.YapilanMuayeneGoster.ItemHeight = 21;
            this.YapilanMuayeneGoster.Location = new System.Drawing.Point(0, 110);
            this.YapilanMuayeneGoster.Name = "YapilanMuayeneGoster";
            this.YapilanMuayeneGoster.Size = new System.Drawing.Size(800, 340);
            this.YapilanMuayeneGoster.TabIndex = 1;
            // 
            // frmYapilanTumMuayeneleriGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YapilanMuayeneGoster);
            this.Controls.Add(this.btnMuayeneGoster);
            this.Name = "frmYapilanTumMuayeneleriGoruntule";
            this.Text = "YAPILAN MUAYENELER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuayeneGoster;
        private System.Windows.Forms.ListBox YapilanMuayeneGoster;
    }
}