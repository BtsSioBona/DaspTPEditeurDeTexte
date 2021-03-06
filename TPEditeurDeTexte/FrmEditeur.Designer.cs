﻿namespace TPEditeurDeTexte
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
            this.components = new System.ComponentModel.Container();
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEnregister = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRetablir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuColler = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxAnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxRetablir = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxColler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.ctxMnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.ContextMenuStrip = this.ctxMnu;
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
            this.MnuEdition});
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
            // MnuOuvrir
            // 
            this.MnuOuvrir.Name = "MnuOuvrir";
            this.MnuOuvrir.Size = new System.Drawing.Size(157, 22);
            this.MnuOuvrir.Text = "Ouvrir";
            this.MnuOuvrir.Click += new System.EventHandler(this.MnuOuvrir_Click);
            // 
            // MnuEnregister
            // 
            this.MnuEnregister.Name = "MnuEnregister";
            this.MnuEnregister.Size = new System.Drawing.Size(157, 22);
            this.MnuEnregister.Text = "Enregistrer sous";
            this.MnuEnregister.Click += new System.EventHandler(this.MnuEnregister_Click);
            // 
            // MnuQuitter
            // 
            this.MnuQuitter.Name = "MnuQuitter";
            this.MnuQuitter.Size = new System.Drawing.Size(157, 22);
            this.MnuQuitter.Text = "Quitter";
            this.MnuQuitter.Click += new System.EventHandler(this.MnuQuitter_Click);
            // 
            // MnuEdition
            // 
            this.MnuEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAnnuler,
            this.MnuRetablir,
            this.MnuCopier,
            this.MnuColler});
            this.MnuEdition.Name = "MnuEdition";
            this.MnuEdition.Size = new System.Drawing.Size(56, 20);
            this.MnuEdition.Text = "&Edition";
            // 
            // MnuAnnuler
            // 
            this.MnuAnnuler.Name = "MnuAnnuler";
            this.MnuAnnuler.Size = new System.Drawing.Size(152, 22);
            this.MnuAnnuler.Text = "Annuler";
            this.MnuAnnuler.Click += new System.EventHandler(this.MnuAnnuler_Click);
            // 
            // MnuRetablir
            // 
            this.MnuRetablir.Name = "MnuRetablir";
            this.MnuRetablir.Size = new System.Drawing.Size(152, 22);
            this.MnuRetablir.Text = "Rétablir";
            this.MnuRetablir.Click += new System.EventHandler(this.MnuRetablir_Click);
            // 
            // MnuCopier
            // 
            this.MnuCopier.Name = "MnuCopier";
            this.MnuCopier.Size = new System.Drawing.Size(152, 22);
            this.MnuCopier.Text = "Copier";
            this.MnuCopier.Click += new System.EventHandler(this.MnuCopier_Click);
            // 
            // MnuColler
            // 
            this.MnuColler.Name = "MnuColler";
            this.MnuColler.Size = new System.Drawing.Size(152, 22);
            this.MnuColler.Text = "Coller";
            this.MnuColler.Click += new System.EventHandler(this.MnuColler_Click);
            // 
            // ctxMnu
            // 
            this.ctxMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxAnuler,
            this.CtxRetablir,
            this.CtxCopier,
            this.CtxColler});
            this.ctxMnu.Name = "ctxMnu";
            this.ctxMnu.Size = new System.Drawing.Size(117, 92);
            // 
            // CtxAnuler
            // 
            this.CtxAnuler.Name = "CtxAnuler";
            this.CtxAnuler.Size = new System.Drawing.Size(152, 22);
            this.CtxAnuler.Text = "Annuler";
            this.CtxAnuler.Click += new System.EventHandler(this.CtxAnuler_Click);
            // 
            // CtxRetablir
            // 
            this.CtxRetablir.Name = "CtxRetablir";
            this.CtxRetablir.Size = new System.Drawing.Size(152, 22);
            this.CtxRetablir.Text = "Rétablir";
            this.CtxRetablir.Click += new System.EventHandler(this.CtxRetablir_Click);
            // 
            // CtxCopier
            // 
            this.CtxCopier.Name = "CtxCopier";
            this.CtxCopier.Size = new System.Drawing.Size(152, 22);
            this.CtxCopier.Text = "Copier";
            this.CtxCopier.Click += new System.EventHandler(this.CtxCopier_Click);
            // 
            // CtxColler
            // 
            this.CtxColler.Name = "CtxColler";
            this.CtxColler.Size = new System.Drawing.Size(152, 22);
            this.CtxColler.Text = "Coller";
            this.CtxColler.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
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
            this.ctxMnu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAffiche;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuFichier;
        private System.Windows.Forms.ToolStripMenuItem MnuEdition;
        private System.Windows.Forms.ToolStripMenuItem MnuOuvrir;
        private System.Windows.Forms.ToolStripMenuItem MnuEnregister;
        private System.Windows.Forms.ToolStripMenuItem MnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem MnuAnnuler;
        private System.Windows.Forms.ToolStripMenuItem MnuRetablir;
        private System.Windows.Forms.ToolStripMenuItem MnuCopier;
        private System.Windows.Forms.ToolStripMenuItem MnuColler;
        private System.Windows.Forms.ContextMenuStrip ctxMnu;
        private System.Windows.Forms.ToolStripMenuItem CtxAnuler;
        private System.Windows.Forms.ToolStripMenuItem CtxRetablir;
        private System.Windows.Forms.ToolStripMenuItem CtxCopier;
        private System.Windows.Forms.ToolStripMenuItem CtxColler;
    }
}

