using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace TPEditeurDeTexte
{
    public partial class FrmEditeur : Form
    {
        public FrmEditeur()
        {
            InitializeComponent();
        }

        private void MnuEnregister_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = @"Documents\";
            saveDialog.Filter = "Fichier texte (*.txt)|*.*";
            DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = rtbAffiche.Text;
                File.WriteAllText(saveDialog.FileName, file);
            }
        }

        private void MnuOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = @"Documents\";
            openDialog.Filter = "TXT files|*.txt";
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openDialog.FileName;
                string text = File.ReadAllText(file);
                rtbAffiche.Text = text;
            }
        }

        private void MnuCopier_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(rtbAffiche.Text);
        }

        private void MnuColler_Click(object sender, EventArgs e)
        {
            rtbAffiche.AppendText(Clipboard.GetText());
        }
        string text;
        private void MnuAnnuler_Click(object sender, EventArgs e)
        {
            text = rtbAffiche.Text;
            rtbAffiche.ResetText();
        }

        private void MnuRetablir_Click(object sender, EventArgs e)
        {
            rtbAffiche.Text = text;
        }

        private void CtxAnuler_Click(object sender, EventArgs e)
        {
            text = rtbAffiche.Text;
            rtbAffiche.ResetText();
        }

        private void CtxRetablir_Click(object sender, EventArgs e)
        {
            rtbAffiche.Text = text;
        }

        private void CtxCopier_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(rtbAffiche.Text);
        }
        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbAffiche.AppendText(Clipboard.GetText());
        }
        private void MnuQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
