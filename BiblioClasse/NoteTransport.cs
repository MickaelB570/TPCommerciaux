using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    [System.Serializable]
    public class NoteTransport : NoteFrais
    {
        private int nbkm;
        private int idNote;

        /// <summary>
        /// Constructeur d'une note de transport (hérite de la classe mère note de frais).
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="c"></param>
        /// <param name="pnbkm"></param>
        public NoteTransport(DateTime Date, Commercial c, int pnbkm) : base(Date,c)
        {
            nbkm = pnbkm;
            idNote = c.LesNotesFrais.Count;

        }
        /// <summary>
        /// Retourne le montant à remboursée en fonction de la puissance de la voiture.
        /// </summary>
        /// <returns>double</returns>
        public override double calculMontantARembourser()
        {
            double prixPuissance;

            if(LeCommercial.PuissanceVoiture < 5)
            {
                prixPuissance = 0.1;
            } else
            {
                if (LeCommercial.PuissanceVoiture > 4 && LeCommercial.PuissanceVoiture < 11)
                {
                    prixPuissance = 0.2;
                }
                else
                {

                    prixPuissance = 0.3;
                }
            }
            return (nbkm * prixPuissance) + base.calculMontantARembourser(); 
        }

        /// <summary>
        /// Retourne une chaine de caractère avec l'ID de la note, la date de la note de frais, le montant à remboursée et s'il est remboursée ou non
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

            return "Transport -numéro : " + idNote +" - Date :" + this.DateFrais + " - montant à rembourser : " + calculMontantARembourser() + 
                    " euros - " + temp + "- " + nbkm + " km-";
        }
    }
}
