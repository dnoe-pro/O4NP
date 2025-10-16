using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace PassGenie.Classes
{
    public class MotDePasse
    {
        private string mdp;
        private int longueur;
        private static Random random = new Random();
        public MotDePasse() { }

        public MotDePasse(string _mdp, int _longueur)
        {
            this.mdp = _mdp;
            this.longueur = _longueur;
        }

        public string getMdp() { return this.mdp; }
        public int getLongueur() { return this.longueur; }
        public void setMdp(string _mdp) { this.mdp = _mdp; }
        public void setLongueur(int _longueur) { this.longueur = _longueur; }

        /*---------------------------------------------- GENERATION MDP -------------------------------------------*/
        public string GenererMdp(int longueur)
        {
            // Vérifie que la longueur entre 12 à 50 caractères
            longueur = Math.Clamp(longueur, 12, 50);

            const string minuscules = "abcdefghijklmnopqrstuvwxyz";
            const string majuscules = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string chiffres = "0123456789";
            const string symboles = "!?@#$%&*()+=-";

            string tousLesCaracteres = minuscules + majuscules + chiffres + symboles;

            // S'assure qu'au moins un caractère de chaque catégorie est présent
            StringBuilder motDePasse = new StringBuilder();
            motDePasse.Append(minuscules[random.Next(minuscules.Length)]);
            motDePasse.Append(majuscules[random.Next(majuscules.Length)]);
            motDePasse.Append(chiffres[random.Next(chiffres.Length)]);
            motDePasse.Append(symboles[random.Next(symboles.Length)]);

            // Remplir le mot de passe avec des caractères aléatoires
            for (int i = motDePasse.Length; i < longueur; i++)
            {
                motDePasse.Append(tousLesCaracteres[random.Next(tousLesCaracteres.Length)]);
            }
            return Melanger(motDePasse.ToString());
        }

        // Mélange les caractères pour éviter une séquence prévisible en générant plusieurs fois
        private string Melanger(string str)
        {
            char[] array = str.ToCharArray();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                (array[k], array[n]) = (array[n], array[k]);
            }
            return new string(array);
        }

        /*---------------------------------------------- VERIFICATION MDP -------------------------------------------*/

        public bool ContientLongueurSuffisante(string motDePasse)
        {
            return motDePasse.Length >= 12;
        }
        public bool ContientMajuscule(string motDePasse)
        {
            return motDePasse.Any(char.IsUpper);
        }

        public bool ContientChiffre(string motDePasse)
        {
            return motDePasse.Any(char.IsDigit);
        }

        public bool ContientSymbole(string motDePasse)
        {
            return motDePasse.Any(c => "!?@#$%&*()+=-".Contains(c));
        }
        public bool dictMotsConnus(string motDePasse)
        {
            //string fichier = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Dictionnaires\1000000-most-common-passwords.txt");
            string fichier = @"E:\01-COURS\BTSSIO_2.1\B2\FORTIN\O4NProject\O4NP\PassGenie\Dictionnaires\1000000-most-common-passwords.txt";
            // Vérifie si le fichier existe
            if (!File.Exists(fichier))
            {
                MessageBox.Show("le fichier est introuvable");
                return false;
            }

            string[] motsConnus = File.ReadAllLines(fichier);

            // Convertir le mdp en minuscule pour comparer les combinaison
            string motDePasseMin = motDePasse.ToLower();

            // Vérifie si le mdp contient l'un des mots connus
            foreach (string motConnu in motsConnus)
            {
                if (!string.IsNullOrEmpty(motConnu) && motDePasseMin.Contains(motConnu.ToLower()))
                {
                    return true; // return si le mdp contient le mot connu
                }
            }
            return false; // return si le mdp ne contient pas le mot connu
        }
    }
}
