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
    /// <summary>
    /// Constructeur formulaire ajout commerciale
    /// </summary>
    public partial class FrmAjoutCommercial : Form
    {
        ServiceCommercial leService = new ServiceCommercial();
        /// <summary>
        /// Formulaire ajout sans paramètre
        /// </summary>
        public FrmAjoutCommercial()
        {
            InitializeComponent();
        }
        /// <summary>
        /// formulaire ajout Commercial
        /// </summary>
        /// <param name="sc"></param>
        public FrmAjoutCommercial(ServiceCommercial sc)
        {
            InitializeComponent();
            leService = sc;
            try
            {
                foreach (Commercial unCommercial in sc.LesCommerciaux)
                {

                       cbb_puissance.Items.Add(unCommercial.PuissanceVoiture);

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void lst_form2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_form2_valider_Click(object sender, EventArgs e)
        {
            if ((rdb_form2_A != null || rdb_form2_B != null || rdb_form2_C != null) && txt_nom != null && txt_prenom != null && cbb_puissance != null)
            {
                string cat;
                char cat_char;
                double puissance;

                if (rdb_form2_A != null)
                {
                    cat = rdb_form2_A.Text;
                } else if (rdb_form2_B != null)
                {
                    cat = rdb_form2_B.Text;
                } else
                {
                    cat = rdb_form2_C.Text;
                }

                cat_char = Convert.ToChar(cat);
                try
                {
                    puissance = Convert.ToDouble(cbb_puissance.Text);
                    Commercial unCommercial = new Commercial(txt_prenom.Text, txt_nom.Text, puissance, cat_char);
                    cbb_puissance.Items.Add(cbb_puissance.Text);
                    leService.ajouterCommercial(unCommercial);
                    lbl_form2_affichage.Text = unCommercial.ToString() + " Ajouté !";


                }
                catch (Exception)
                {

                    MessageBox.Show("type invalide pour puisance de vehicule");
                }


                }
        }
    }
}
