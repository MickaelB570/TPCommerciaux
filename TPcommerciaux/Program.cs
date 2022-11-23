using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioClasse;

namespace TPcommerciaux
{
    class Program
    {
        static void Main(string[] args)
        {


            ServiceCommercial sc2;
            Commercial c2;
            Commercial c3;
            sc2 = new ServiceCommercial();
            c2 = new Commercial("Dupond", "Jean", 7, 'B');
            c3 = new Commercial("Dupont", "Robert", 7, 'B');
            Console.WriteLine("/////////////////////////////////Premier Test///////////////////////////////");

            sc2.ajouterCommercial(c2);
            sc2.ajouterCommercial(c3);
            sc2.ajouterNote(c2, new DateTime(2013, 11, 15), 100); // ajoute un frais de transport 
            sc2.ajouterNote(c2, new DateTime(2013, 11, 21), 15.5); // ajoute une note de repas 
            sc2.ajouterNote(c2, new DateTime(2013, 11, 25), 105, 2); // ajoute une nuitée 

            foreach (NoteFrais note in c2.LesNotesFrais)
            {
                Console.WriteLine(note.ToString());
            }


            foreach (NoteFrais uneNote in c2.LesNotesFrais)
            {
                uneNote.EstRemboursée = true;
            }
            
            Console.WriteLine(c2.rembourséeAnnée(2013));
            Console.WriteLine("/////////////////////////////////Second Test///////////////////////////////");
            Console.WriteLine( sc2.afficheLesCommerciaux());
            Console.WriteLine("/////////////////////////////////Troisème Test///////////////////////////////");

            PersiteCommercial.sauve(sc2, "service.sr"); // le ServiceCommercial sc est sérialisé et enregistré en mémoire
            ServiceCommercial sc1 = PersiteCommercial.charge("service.sr"); //le ServiceCommercial sc1 est désérialisé
            Console.WriteLine( sc1.afficheLesCommerciaux());

            Console.ReadLine();
        }
    }
}
