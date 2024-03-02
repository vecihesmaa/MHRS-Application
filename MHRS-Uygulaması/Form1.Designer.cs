namespace ailehekimidonemproje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iŞLEMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAPILANTÜMMUAYENELERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dENEMEKISITLIREÇETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKINDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iŞLEMLERToolStripMenuItem,
            this.hAKKINDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            this.iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem,
            this.hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem,
            this.yAPILANTÜMMUAYENELERToolStripMenuItem,
            this.dENEMEKISITLIREÇETEToolStripMenuItem});
            this.iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            this.iŞLEMLERToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem
            // 
            this.gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem.Name = "gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem";
            this.gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem.Text = "GEÇMİŞ REÇETELERİ GÖRÜNTÜLE";
            this.gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem.Click += new System.EventHandler(this.gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem_Click);
            // 
            // hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem
            // 
            this.hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem.Name = "hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem";
            this.hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem.Text = "HASTANIN İLAÇLARINI GÖRÜNTÜLE";
            this.hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem.Click += new System.EventHandler(this.hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem_Click);
            // 
            // yAPILANTÜMMUAYENELERToolStripMenuItem
            // 
            this.yAPILANTÜMMUAYENELERToolStripMenuItem.Name = "yAPILANTÜMMUAYENELERToolStripMenuItem";
            this.yAPILANTÜMMUAYENELERToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.yAPILANTÜMMUAYENELERToolStripMenuItem.Text = "YAPILAN TÜM MUAYENELER";
            this.yAPILANTÜMMUAYENELERToolStripMenuItem.Click += new System.EventHandler(this.yAPILANTÜMMUAYENELERToolStripMenuItem_Click);
            // 
            // dENEMEKISITLIREÇETEToolStripMenuItem
            // 
            this.dENEMEKISITLIREÇETEToolStripMenuItem.Name = "dENEMEKISITLIREÇETEToolStripMenuItem";
            this.dENEMEKISITLIREÇETEToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.dENEMEKISITLIREÇETEToolStripMenuItem.Text = "YENİ REÇETE EKLE";
            this.dENEMEKISITLIREÇETEToolStripMenuItem.Click += new System.EventHandler(this.dENEMEKISITLIREÇETEToolStripMenuItem_Click);
            // 
            // hAKKINDAToolStripMenuItem
            // 
            this.hAKKINDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çIKIŞToolStripMenuItem});
            this.hAKKINDAToolStripMenuItem.Name = "hAKKINDAToolStripMenuItem";
            this.hAKKINDAToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.hAKKINDAToolStripMenuItem.Text = "HAKKINDA";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gEÇMİŞREÇETELERİGÖRÜNTÜLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hASTANINİLAÇLARINIGÖRÜNTÜLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yAPILANTÜMMUAYENELERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKINDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dENEMEKISITLIREÇETEToolStripMenuItem;
    }
}

