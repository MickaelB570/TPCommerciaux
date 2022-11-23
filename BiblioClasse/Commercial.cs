using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasse
{
    [System.Serializable]
    public class Commercial
    {
        private string nom;
        private string prenom;
        private char laCatPro;
        private ServiceCommercial leServiceCommercial;
        private double puissanceVoiture;
        private List<NoteFrais> lesNotesFrais = new List<NoteFrais>();

        /// <summary>
        /// Nom du commercial
        /// </summary>
        public string Nom { get => nom; set => nom = value; }
        /// <summary>
        /// Prenom du commercial
        /// </summary>
        public string Prenom { get => prenom; set => prenom = value; }
        /// <summary>
        /// La catégorie professionnel du commercial
        /// </summary>
        public char LaCatPro { get => laCatPro; set => laCatPro = value; }
        /// <summary>
        /// Le service commercial du commercial
        /// </summary>
        public ServiceCommercial LeServiceCommercial { get => leServiceCommercial; set => leServiceCommercial = value; }
        /// <summary>
        /// La puissance de la voiture du commercial
        /// </summary>
        public double PuissanceVoiture { get => puissanceVoiture; set => puissanceVoiture = value; }
        /// <summary>
        /// Liste des notes de frais lié au commercial
        /// </summary>
        public List<NoteFrais> LesNotesFrais { get => lesNotesFrais; set => lesNotesFrais = value; }
        /// <summary>
        /// Constructeur du commercial
        /// </summary>
        /// <param name="pPrenom"></param>
        /// <param name="pNom"></param>
        /// <param name="pPuissanceVoiture"></param>
        /// <param name="pLaCatPro"></param>

        public Commercial(string pPrenom, string pNom,double pPuissanceVoiture, char pLaCatPro)
        {
            prenom = pPrenom;
            nom = pNom;
            puissanceVoiture = pPuissanceVoiture;
            laCatPro = pLaCatPro;
            lesNotesFrais = new List<NoteFrais>();
        }

        public Commercial()
        {
        }
        /// <summary>
        /// Ajouter une note de frais à un commercial
        /// </summary>
        /// <param name="f"></param>
        public void ajouterNoteFrais(NoteFrais f)
        {
            lesNotesFrais.Add(f);
        }

        /// <summary>
        /// Affichage du nom, prenom, puissance de voitre et de la catégorie profesionnel du commercial
        /// </summary>
        /// <returns>Chaine de caractères</returns>
        public override string ToString()
        {
            return  "Prenom : " + prenom + ", Nom : " + nom +  ", Puissance voiture : " + puissanceVoiture + ", Catégorie professionnel : " + laCatPro; 
        }

        /// <summary>
        /// Montant des notes remboursées
        /// </summary>
        /// <param name="année"></param>
        /// <returns>un double</returns>
        public double rembourséeAnnée(int année)
        {
            double cumul = 0;

            foreach(NoteFrais uneNote in lesNotesFrais)
            {
                if (uneNote.DateFrais.Year ==  année)
                {

                    if (uneNote.EstRemboursée)
                    {
                        cumul += uneNote.calculMontantARembourser();
                    }
                }
            }

            return cumul;
        }
    }
}
