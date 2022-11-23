using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioClasse
{
    [System.Serializable]
    public abstract class NoteFrais
    {
        private DateTime dateFrais;
        private double montantARembourser;
        private bool estRemboursée;
        private int idNote;
        private Commercial leCommercial;

        /// <summary>
        /// Retourne le montant à remboursée
        /// </summary>
        public double MontantARembourser { get => montantARembourser; set => montantARembourser = calculMontantARembourser(); }
        /// <summary>
        ///  Retourne le commmercial concerné par la note de frais
        /// </summary>
        public Commercial LeCommercial { get => leCommercial; set => leCommercial = value; }
        /// <summary>
        /// Retourne si la note est remboursée ou non
        /// </summary>
        public bool EstRemboursée { get => estRemboursée; set => estRemboursée = value; }
        /// <summary>
        /// Retourne la date de l'établissement de la note de frais
        /// </summary>
        public DateTime DateFrais { get => dateFrais; set => dateFrais = value; }

        /// <summary>
        /// Constructeur d'une note de frais
        /// </summary>
        /// <param name="pDateFrais"></param>
        /// <param name="unCommercial"></param>
        public NoteFrais(DateTime pDateFrais, Commercial unCommercial)
        {
            dateFrais = pDateFrais;
            leCommercial = unCommercial;
            estRemboursée = false;
            idNote = leCommercial.LesNotesFrais.Count;

        }

        /// <summary>
        /// Permet d'avoir le montant à remboursée 
        /// </summary>
        /// <returns>un double</returns>
        public virtual double calculMontantARembourser()
        {
            return 0;
        }

        /// <summary>
        /// Permet d'avoir une chaine de caractère avec id de la note, les information du commercial, le montant à remboursée et si le montant est rembousée
        /// </summary>
        /// <returns>Une chaine de caractère</returns>
        public override string ToString()
        {
            string temp;
            if (estRemboursée == true)
            {
                temp = "Remboursé"; 
            } else
            {
                temp = "Non remboursé";
            }

            return "Numéro de la note : " + idNote + ", "+ leCommercial.ToString() + ", Montant à rembourser : " + montantARembourser + " - " + temp ; 
        }

    }
}