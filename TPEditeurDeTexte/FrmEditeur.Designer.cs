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
            this.fichierFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fichierFToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(292, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // fichierFToolStripMenuItem
            // 
            this.fichierFToolStripMenuItem.Name = "fichierFToolStripMenuItem";
            this.fichierFToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierFToolStripMenuItem.Text = "&Fichier";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "&Edition";
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
        private System.Windows.Forms.ToolStripMenuItem fichierFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    }
}

