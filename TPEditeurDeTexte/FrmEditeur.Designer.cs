namespace TPEditeurDeTexte
{
    partial class FrmEditeur
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
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEnregister = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.Location = new System.Drawing.Point(-1, 27);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAffiche.Size = new System.Drawing.Size(293, 329);
            this.rtbAffiche.TabIndex = 0;
            this.rtbAffiche.Text = "";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFichier,
            this.editionToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(292, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // MnuFichier
            // 
            this.MnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOuvrir,
            this.MnuEnregister,
            this.MnuQuitter});
            this.MnuFichier.Name = "MnuFichier";
            this.MnuFichier.Size = new System.Drawing.Size(54, 20);
            this.MnuFichier.Text = "&Fichier";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "&Edition";
            // 
            // MnuOuvrir
            // 
            this.MnuOuvrir.Name = "MnuOuvrir";
            this.MnuOuvrir.Size = new System.Drawing.Size(157, 22);
            this.MnuOuvrir.Text = "Ouvrir";
            // 
            // MnuEnregister
            // 
            this.MnuEnregister.Name = "MnuEnregister";
            this.MnuEnregister.Size = new System.Drawing.Size(157, 22);
            this.MnuEnregister.Text = "Enregistrer sous";
            this.MnuEnregister.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // MnuQuitter
            // 
            this.MnuQuitter.Name = "MnuQuitter";
            this.MnuQuitter.Size = new System.Drawing.Size(157, 22);
            this.MnuQuitter.Text = "Quitter";
            // 
            // FrmEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 356);
            this.Controls.Add(this.rtbAffiche);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmEditeur";
            this.Text = "Mon petit éditeur";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAffiche;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuFichier;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuOuvrir;
        private System.Windows.Forms.ToolStripMenuItem MnuEnregister;
        private System.Windows.Forms.ToolStripMenuItem MnuQuitter;
    }
}

