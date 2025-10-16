using System.Runtime.InteropServices;
using System;
using PassGenie.Classes;

namespace PassGenie
{
    public partial class F_GenerateurMdp : Form
    {
        public F_GenerateurMdp()
        {
            InitializeComponent();
        }

        MotDePasse g = new MotDePasse();

        /* Permet de generer la longueur du mot de passe en scrollant le TrackBar de 12 à 50 caractères */
        private void tbr_longueur_Scroll(object sender, EventArgs e)
        {
            int longueur = tbr_longueur.Value;
            l_longueur_valeur.Text = "Longueur :" + longueur;
            g.setLongueur(longueur);
        }

        /* Bouton pour génerer un mot de passe suivant les recommandations de la CNIL */
        private void btn_generer_mdp_Click(object sender, EventArgs e)
        {
            int longueur = g.getLongueur();
            tb_mdp.Text = g.GenererMdp(longueur);// Generer et affichage d'un mot de passe généré dans le textBox
        }

        /* Bouton pour copier le mot de passe dans le champ de texte */
        private void btn_copier_mdp_Click(object sender, EventArgs e)
        {
            // Si le champ de texte n'est pas vide donc l'utilisateur peut copier la valeur du champ de texte
            if (!string.IsNullOrEmpty(tb_mdp.Text))
            {
                Clipboard.SetText(tb_mdp.Text);
            }
        }

        /* Bouton pour Valider l'entrée d'utilisateur et faire des tests unitaires*/
        private void btn_valider_Click(object sender, EventArgs e)
        {
            // Si le champ de texte est vide alors afficher le message
            if (string.IsNullOrEmpty(tb_mdp.Text))
            {
                MessageBox.Show("Le champ de texte doit etre rempli");
                return;
            }
            string mdp = tb_mdp.Text;

            // Vérifie chaque critère individuellement
            bool longue = g.ContientLongueurSuffisante(mdp);
            bool Maj = g.ContientMajuscule(mdp);
            bool chiffre = g.ContientChiffre(mdp);
            bool symbole = g.ContientSymbole(mdp);
            bool motConnu = !g.dictMotsConnus(mdp);

            // Met à jour les labels en fonction des conditions résultats
            l_longueur.ForeColor = longue ? Color.Green : Color.Red;
            l_majuscule.ForeColor = Maj ? Color.Green : Color.Red;
            l_chiffre.ForeColor = chiffre ? Color.Green : Color.Red;
            l_symbole.ForeColor = symbole ? Color.Green : Color.Red;
            l_motconnu.ForeColor = motConnu ? Color.Green : Color.Red;
        }
    }
}