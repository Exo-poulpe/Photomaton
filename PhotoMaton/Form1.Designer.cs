﻿namespace PhotoMaton
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
            this.menuStrip1.SuspendLayout();
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
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.twistToolStripMenuItem});
            this.transformationToolStripMenuItem.Name = "transformationToolStripMenuItem";
            this.transformationToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.transformationToolStripMenuItem.Text = "Transformation";
            // 
            // photoMatonToolStripMenuItem
            // 
            this.photoMatonToolStripMenuItem.Name = "photoMatonToolStripMenuItem";
            this.photoMatonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.photoMatonToolStripMenuItem.Text = "PhotoMaton";
            // 
            // boulangerToolStripMenuItem
            // 
            this.boulangerToolStripMenuItem.Name = "boulangerToolStripMenuItem";
            this.boulangerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boulangerToolStripMenuItem.Text = "Boulanger";
            // 
            // couplageToolStripMenuItem
            // 
            this.couplageToolStripMenuItem.Name = "couplageToolStripMenuItem";
            this.couplageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.couplageToolStripMenuItem.Text = "Couplage";
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inverseToolStripMenuItem.Text = "Inverse";
            // 
            // doubleBinaireToolStripMenuItem
            // 
            this.doubleBinaireToolStripMenuItem.Name = "doubleBinaireToolStripMenuItem";
            this.doubleBinaireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doubleBinaireToolStripMenuItem.Text = "Double Binaire";
            // 
            // twistToolStripMenuItem
            // 
            this.twistToolStripMenuItem.Name = "twistToolStripMenuItem";
            this.twistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.twistToolStripMenuItem.Text = "Twist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 523);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoMatonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boulangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couplageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleBinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twistToolStripMenuItem;
    }
}

