using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    [System.Serializable]
    public class NoteRepas : NoteFrais
    {
        private double repas;
        private int idNote;
        /// <summary>
        /// Constructeur d'une note de Repas (hérite de la classe mère note de frais).
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="c"></param>
        /// <param name="prepas"></param>
        public NoteRepas(DateTime Date,Commercial c,double prepas): base(Date,c)
        {
            repas = prepas;
            idNote = c.LesNotesFrais.Count;

        }
        /// <summary>
        /// Retourne le montant à remboursée en fonction de la catégorie du commercial
        /// </summary>
        /// <returns>double</returns>
        public override double calculMontantARembourser()
        {
            double remboursement;

            if (this.LeCommercial.LaCatPro == 'A')
            {
                remboursement = 25;
            }
            else
            {
                if (LeCommercial.LaCatPro == 'B')
                {
                    remboursement = 22;
                }
                else
                {

                    remboursement = 20;
                }
            }

            if (repas <= remboursement)
            {
                remboursement = repas;
            }

            return base.calculMontantARembourser() + remboursement;
        }
        /// <summary>
        /// Retourne une chaine de caractère avec l'ID de la note, la date de la note de frais, le montant à remboursée, s'il est remboursée ou non, avec le prix du repas.
        /// </summary>
        /// <returns>Une chaine de caractère</returns>
        public override string ToString()
        {
            string temp;
            if (EstRemboursée == true)
            {
                temp = "Remboursé";
            }
            else
            {
                temp = "Non remboursé";
            }

            return "Repas -numéro : " + idNote + " - Date :" + this.DateFrais + " - montant à rembourser : " + calculMontantARembourser() +
                    " euros - " + temp + "- Prix du repas " + repas + " euros-";
        }
    }
}
