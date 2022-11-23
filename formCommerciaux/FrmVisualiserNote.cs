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
    public partial class FrmVisualiserNote : Form
    {
        Commercial leCommercial = new Commercial();
        ServiceCommercial leService;

        /// <summary>
        /// Formulaire visualisation note
        /// </summary>
        /// <param name="leService"></param>
        public FrmVisualiserNote(BiblioClasse.ServiceCommercial leService)
        {
            InitializeComponent();
            this.leService = leService;




            foreach (Commercial unCommercial in leService.LesCommerciaux)
            {
                string txt;
                txt = unCommercial.Nom + " " + unCommercial.Prenom;

                lst_VisualiserNote_Commerciaux.Items.Add(txt);
            }


            lst_VisualiserNote_Commerciaux.SelectedIndex = 0;


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_VisualiserNote_Commerciaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            leCommercial = analyse();
            lst_VisualiserNote.Items.Clear();
            foreach (NoteFrais uneNote in leCommercial.LesNotesFrais)
            {
                lst_VisualiserNote.Items.Add(uneNote.ToString());
            }
            if (leCommercial.LesNotesFrais.Count == 0)
            {
                lst_VisualiserNote.Items.Add("Ce commercial n'a pas de note");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Commercial analyse()
        {
            string phrase = Convert.ToString(lst_VisualiserNote_Commerciaux.SelectedItem);
            string[] words = phrase.Split(' ');
            string Nom = "";
            string Prenom = "";
            Commercial TheCommercial = new Commercial();
            int cumul = 1;
            

            foreach (var word in words)
            {
                if (cumul == 1)
                {
                    Nom = word;
                }
                else
                {
                    Prenom = word;

                }
                cumul++;
            }

            foreach (Commercial unCommercial in leService.LesCommerciaux)
            {
                if (unCommercial.Nom == Nom && unCommercial.Prenom == Prenom)
                {
                    TheCommercial = unCommercial;
                }
            }
            return TheCommercial;
        }
    }
}
