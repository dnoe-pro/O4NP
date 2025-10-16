using System.Runtime.InteropServices;
using System;
using PassGenie.Classes;

namespace PassGenie
{
    public partial class F_GenerateurMdp : Form
    {
        MotDePasse g = new MotDePasse();
        public F_GenerateurMdp()
        {
            InitializeComponent();
        }

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
            // Generer et affichage d'un mot de passe généré dans le textBox
            tb_mdp.Text = g.GenererMdp(longueur);
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
    }
}
