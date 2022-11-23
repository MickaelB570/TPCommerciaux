using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioClasse
{
    [System.Serializable]
    public class ServiceCommercial
    {
        private List<Commercial> lesCommerciaux = new List<Commercial>();

        /// <summary>
        /// Retourne la liste des commerciaux appartenant à un service commercial
        /// </summary>
        public List<Commercial> LesCommerciaux { get => lesCommerciaux; set => lesCommerciaux = value; }

        public ServiceCommercial()
        {

        }
        /// <summary>
        /// Permet d'ajouter un commercial
        /// </summary>
        /// <param name="c"></param>
        public void ajouterCommercial(Commercial c)
        {
            lesCommerciaux.Add(c);
        }

        /// <summary>
        /// Permet d'ajouter une note de transport à un commercial.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="date"></param>
        /// <param name="nbkm"></param>
        public void ajouterNote(Commercial c, DateTime date, int nbkm)
        {
            c.LesNotesFrais.Add(new NoteTransport(date, c,nbkm));
        }
        /// <summary>
        /// Permet d'ajouter une note de repas à un commercial
        /// </summary>
        /// <param name="c"></param>
        /// <param name="date"></param>
        /// <param name="prix"></param>
        public void ajouterNote(Commercial c, DateTime date, double prix)
        {
            c.LesNotesFrais.Add(new NoteRepas(date, c, prix));
        }

        /// <summary>
        /// Permet d'ajouter une note de nuitée à un commercial.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="date"></param>
        /// <param name="prix"></param>
        /// <param name="region"></param>
        public void ajouterNote(Commercial c, DateTime date, double prix, int region)
        {
            c.LesNotesFrais.Add(new NoteNuit(date, c, prix, region));
        }


        public int nbFraisNonRemboursés()
        {
            int cumul = 0;
            foreach (Commercial c in lesCommerciaux)
            {
                foreach (NoteFrais n in c.LesNotesFrais)
                {
                    if (n.EstRemboursée == false)
                    {
                        cumul += 1;
                    }
                }
            }
            return cumul;
        }
        /// <summary>
        /// Permet de retourner une chaine de caractère avec tous les commerciaux du service commercial.
        /// </summary>
        /// <returns></returns>
        public string afficheLesCommerciaux()
        {
            string n = "";
            foreach (Commercial c in lesCommerciaux)
            {
                n += "Commercial : " + c.ToString() + "\n";

                foreach (NoteFrais note in c.LesNotesFrais)
                {

                    n += note.ToString() + "\n";
                }
            }
            return n;

        }
    }
}