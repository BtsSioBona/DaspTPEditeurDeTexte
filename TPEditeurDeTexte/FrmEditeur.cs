using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPEditeurDeTexte
{
    public partial class FrmEditeur : Form
    {
        public FrmEditeur()
        {
            InitializeComponent();
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"Documents\";
            save.Filter = "Fichier texte (*.txt)|*.*";
            save.Title = "Enregister le fichier";
            save.ShowDialog();
        }

        private void MnuQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
