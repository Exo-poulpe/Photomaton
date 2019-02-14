namespace PhotoMaton
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoMatonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boulangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couplageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleBinaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swastikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pibImg = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.transformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // transformationToolStripMenuItem
            // 
            this.transformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.photoMatonToolStripMenuItem,
            this.boulangerToolStripMenuItem,
            this.couplageToolStripMenuItem,
            this.inverseToolStripMenuItem,
            this.doubleBinaireToolStripMenuItem,
            this.twistToolStripMenuItem,
            this.swastikaToolStripMenuItem});
            this.transformationToolStripMenuItem.Name = "transformationToolStripMenuItem";
            this.transformationToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.transformationToolStripMenuItem.Text = "Transformation";
            // 
            // photoMatonToolStripMenuItem
            // 
            this.photoMatonToolStripMenuItem.Name = "photoMatonToolStripMenuItem";
            this.photoMatonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.photoMatonToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.photoMatonToolStripMenuItem.Text = "PhotoMaton";
            // 
            // boulangerToolStripMenuItem
            // 
            this.boulangerToolStripMenuItem.Name = "boulangerToolStripMenuItem";
            this.boulangerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.boulangerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.boulangerToolStripMenuItem.Text = "Boulanger";
            this.boulangerToolStripMenuItem.Click += new System.EventHandler(this.boulangerToolStripMenuItem_Click);
            // 
            // couplageToolStripMenuItem
            // 
            this.couplageToolStripMenuItem.Name = "couplageToolStripMenuItem";
            this.couplageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.couplageToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.couplageToolStripMenuItem.Text = "Couplage";
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // doubleBinaireToolStripMenuItem
            // 
            this.doubleBinaireToolStripMenuItem.Name = "doubleBinaireToolStripMenuItem";
            this.doubleBinaireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.doubleBinaireToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.doubleBinaireToolStripMenuItem.Text = "Double Binaire";
            this.doubleBinaireToolStripMenuItem.Click += new System.EventHandler(this.doubleBinaireToolStripMenuItem_Click);
            // 
            // twistToolStripMenuItem
            // 
            this.twistToolStripMenuItem.Name = "twistToolStripMenuItem";
            this.twistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.twistToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.twistToolStripMenuItem.Text = "X";
            this.twistToolStripMenuItem.Click += new System.EventHandler(this.twistToolStripMenuItem_Click);
            // 
            // swastikaToolStripMenuItem
            // 
            this.swastikaToolStripMenuItem.Name = "swastikaToolStripMenuItem";
            this.swastikaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.swastikaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.swastikaToolStripMenuItem.Text = "Swastika";
            this.swastikaToolStripMenuItem.Click += new System.EventHandler(this.swastikaToolStripMenuItem_Click);
            // 
            // pibImg
            // 
            this.pibImg.Location = new System.Drawing.Point(19, 48);
            this.pibImg.Name = "pibImg";
            this.pibImg.Size = new System.Drawing.Size(539, 380);
            this.pibImg.TabIndex = 1;
            this.pibImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 523);
            this.Controls.Add(this.pibImg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoMatonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boulangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couplageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleBinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twistToolStripMenuItem;
        private System.Windows.Forms.PictureBox pibImg;
        private System.Windows.Forms.ToolStripMenuItem swastikaToolStripMenuItem;
    }
}

