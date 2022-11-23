using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioClasse;

namespace formCommerciaux
{
    public partial class Form1 : Form
    {
        private ServiceCommercial leService;
        private string nomFichier;

        /// <summary>
        /// Constructeur Formulaire de l'acceuil
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                nomFichier = openFileDialog1.FileName;
                leService = PersiteCommercial.charge(nomFichier);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PersiteCommercial.sauve(leService, nomFichier);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void nouveauCommercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leService == null)
            {
                MessageBox.Show("Veuillez ouvrir le fichier");
            } else
            {
                FrmAjoutCommercial f = new FrmAjoutCommercial(this.leService);
                f.Show();

            }


        }

        private void nouvelleNoteDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leService == null)
            {
                MessageBox.Show("Veuillez ouvrir le fichier");
            }
            else
            {
                FrmAjoutNote f = new FrmAjoutNote(this.leService);
                f.Show();

            }
        }

        private void visiualiserLesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leService == null)
            {
                MessageBox.Show("Veuillez ouvrir le fichier");
            }
            else
            {
                FrmVisualiserNote f = new FrmVisualiserNote(this.leService);
                f.Show();

            }
        }
    }
}
