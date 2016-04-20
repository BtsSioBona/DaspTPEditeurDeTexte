using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            saveDialog.FileName = ".txt";
            saveDialog.Filter = "Fichier texte (*.txt)|*.*";
            saveDialog.Title = "Enregister le fichier";
            saveDialog.ShowDialog();
            FileStream saveFile = (FileStream)saveDialog.OpenFile();
            saveFile.Close();
        }

        private void MnuQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
