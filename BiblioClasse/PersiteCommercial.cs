using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BiblioClasse
{
    [System.Serializable]
    public class PersiteCommercial
    {
        /// <summary>
        /// Sérialise les données du service commercial
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="nomFic"></param>
        public static void sauve(ServiceCommercial sc, string nomFic)
        {

            FileStream fichier = new FileStream(nomFic, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fichier, sc);
            fichier.Close();

        }

        /// <summary>
        /// désérialise les données du service commercial
        /// </summary>
        /// <param name="nomFic"></param>
        /// <returns>retourne un objet ServiceCommercial</returns>
        public static ServiceCommercial charge(string nomFic)
        {
            try
            {
                FileStream fichier = new FileStream(nomFic, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ServiceCommercial sc = (ServiceCommercial)bf.Deserialize(fichier);
                fichier.Close();
                return (sc);

            }
            catch (System.IO.FileNotFoundException)
            {

                throw new System.IO.FileNotFoundException("Le fichier n'existe pas");
            }

            catch (Exception)
            {

                throw new Exception("Fichier invalide");
            }


        }
    }
}
