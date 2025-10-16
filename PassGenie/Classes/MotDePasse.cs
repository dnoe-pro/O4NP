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
        public string GenererMdp(int longueur)
        {
            // Vérifie que la longueur est entre 12
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

        // Mélange les caractères pour éviter une séquence prévisible en generant plusieurs fois
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

        public bool EstMotDePasseFort(string motDePasse)
        {
            if (motDePasse.Length < 12)
                return false;

            bool aMinuscule = motDePasse.Any(char.IsLower);
            bool aMajuscule = motDePasse.Any(char.IsUpper);
            bool aChiffre = motDePasse.Any(char.IsDigit);
            bool aSymbole = motDePasse.Any(c => "!?@#$%&*()+=-".Contains(c));

            string[] sequencesInterdites = { "abcdef", "qwerty", "azerty", "123456", "password", "mamamama" };
            bool contientSequenceInterdite = sequencesInterdites.Any(s => motDePasse.ToLower().Contains(s));

            return aMinuscule && aMajuscule && aChiffre && aSymbole && !contientSequenceInterdite;
        }


        public bool VerificationMdp(string mdp)
        {
            if (mdp.Length < 12) return false;


        }
    }
    
}
