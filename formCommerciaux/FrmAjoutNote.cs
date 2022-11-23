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
    public partial class FrmAjoutNote : Form
    {
        ServiceCommercial leService;

        /// <summary>
        /// Constructeur FRMajout
        /// </summary>
        /// <param name="leService"></param>
        public FrmAjoutNote(BiblioClasse.ServiceCommercial leService)
        {
            InitializeComponent();

            lbl_ajoutNote_nbkm.Visible = false;
            lbl_ajoutNote_PrixNuitee.Visible = false;
            lbl_ajoutNote_prixRepas.Visible = false;
            txb_ajoutNote_nbkm.Visible = false;
            txb_ajoutNote_prixNuitee.Visible = false;
            txb_ajoutNote_prixRepas.Visible = false;
            rdb_ajoutNote_zone1.Visible = false;
            rdb_ajoutNote_zone2.Visible = false;
            rdb_ajoutNote_zone3.Visible = false;
            this.leService = leService;
            chargerListeCommerciaux();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AjoutNote_valider_Click(object sender, EventArgs e)
        {
            string phrase = Convert.ToString(lst_AjoutNote.SelectedItem);
            string[] words = phrase.Split(' ');
            string Nom = "";
            string Prenom = "";
            NoteFrais note;
            int nbkm = 0;
            int typeRegion;
            double prixRepas;
            double prixRegion;

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
                    if (rdb_ajoutNote_Transport.Checked)
                    {
                        try
                        {
                            nbkm = Convert.ToInt32(txb_ajoutNote_nbkm.Text);
                            note = new NoteTransport(dtp_AjoutNote.Value, unCommercial, nbkm);
                            unCommercial.ajouterNoteFrais(note);
                            lbl_ajoutnote_verif.Text = note.ToString() + " Ajouté !"; ;

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Veuillez rentrer des chiffres pour le nombre de kilomètre");
                        }

                    } else if(rdb_AjoutNote_Repas.Checked)
                    {
                        try
                        {
                            prixRepas = Convert.ToDouble(txb_ajoutNote_prixRepas.Text);
                            note = new NoteRepas(dtp_AjoutNote.Value, unCommercial, prixRepas);
                            lbl_ajoutnote_verif.Text = note.ToString() + " Ajouté !";
                            unCommercial.ajouterNoteFrais(note);


                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Veuillez rentrer des chiffres pour le prix du repas");
                        }
                    } else
                    {
                        try
                        {
                            prixRegion = Convert.ToDouble(txb_ajoutNote_prixNuitee.Text);
                            if (rdb_ajoutNote_zone1.Checked == true)
                            {
                                typeRegion = 1;
                            }
                            else if (rdb_ajoutNote_zone2.Checked == true)
                            {
                                typeRegion = 2;
                            }
                            else
                            {
                                typeRegion = 3;
                            } 
                            note = new NoteNuit(dtp_AjoutNote.Value, unCommercial, prixRegion, typeRegion);
                            lbl_ajoutnote_verif.Text = note.ToString() + " Ajouté !"; ;
                            unCommercial.ajouterNoteFrais(note);


                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Veuillez rentrer des chiffres pour le prix du repas ou cocher le type de region");
                        }


                    }
                }
            }
               
        }
        /// <summary>
        /// 
        /// </summary>
        private void chargerListeCommerciaux()
        {
            foreach (Commercial c in leService.LesCommerciaux)
            {
                string nom = c.Nom;
                string prenom = c.Prenom;
                this.lst_AjoutNote.Items.Add(nom + " " + prenom);
            }
            this.lst_AjoutNote.SelectedIndex = 0;     // sélection par défaut du premier
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_ajoutNote_Transport_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ajoutNote_nbkm.Visible = true;
            txb_ajoutNote_nbkm.Visible = true;

            lbl_ajoutNote_PrixNuitee.Visible = false;
            lbl_ajoutNote_prixRepas.Visible = false;
            txb_ajoutNote_prixNuitee.Visible = false;
            txb_ajoutNote_prixRepas.Visible = false;
            rdb_ajoutNote_zone1.Visible = false;
            rdb_ajoutNote_zone2.Visible = false;
            rdb_ajoutNote_zone3.Visible = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_AjoutNote_Repas_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ajoutNote_prixRepas.Visible = true;
            txb_ajoutNote_prixRepas.Visible = true;

            lbl_ajoutNote_nbkm.Visible = false;
            lbl_ajoutNote_PrixNuitee.Visible = false;
            txb_ajoutNote_nbkm.Visible = false;
            txb_ajoutNote_prixNuitee.Visible = false;
            rdb_ajoutNote_zone1.Visible = false;
            rdb_ajoutNote_zone2.Visible = false;
            rdb_ajoutNote_zone3.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_AjoutNote_Nuite_CheckedChanged(object sender, EventArgs e)
        {
            lbl_ajoutNote_PrixNuitee.Visible = true;
            txb_ajoutNote_prixNuitee.Visible = true;
            rdb_ajoutNote_zone1.Visible = true;
            rdb_ajoutNote_zone2.Visible = true;
            rdb_ajoutNote_zone3.Visible = true;

            lbl_ajoutNote_nbkm.Visible = false;
            lbl_ajoutNote_prixRepas.Visible = false;
            txb_ajoutNote_nbkm.Visible = false;
            txb_ajoutNote_prixRepas.Visible = false;

        }
    }
}
