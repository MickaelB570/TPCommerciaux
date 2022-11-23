using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    [System.Serializable]
    public class NoteNuit : NoteFrais
    {
        private double prixHotel;
        private double coefRegion;
        private int idNote;
        /// <summary>
        /// Constructeur d'une note de nuitée (hérite de la classe mère note de frais).
        /// </summary>
        /// <param name="pDateFrais"></param>
        /// <param name="c"></param>
        /// <param name="prix"></param>
        /// <param name="Region"></param>
        public NoteNuit(DateTime pDateFrais,Commercial c, double prix, int Region) : base(pDateFrais, c)
        {
            prixHotel = prix;
            idNote = c.LesNotesFrais.Count;

            if (Region == 1)
            {
                coefRegion = 0.9;
            } else
            {
                if (Region == 2)
                {
                    coefRegion = 1;
                } else
                {
                    coefRegion = 1.1;
                }
             }

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
                remboursement = 65 * coefRegion;
            }
            else
            {
                if (LeCommercial.LaCatPro == 'B')
                {
                    remboursement = 55 * coefRegion;
                }
                else
                {

                    remboursement = 50 * coefRegion;
                }
            }

            if (prixHotel <= remboursement)
            {
                remboursement = prixHotel;
            }

            return base.calculMontantARembourser() + (remboursement);
        }

        /// <summary>
        /// Retourne une chaine de caractère avec l'ID de la note, la date de la note de frais, le montant à remboursée, s'il est remboursée ou non et le coefficient de la region.
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

            return "Nuitée -numéro : " + idNote + " - Date :" + this.DateFrais + " - montant à rembourser : " + calculMontantARembourser() +
                    " euros - " + temp + "- Coeffficient" + coefRegion + " -";
        }
    }
}
