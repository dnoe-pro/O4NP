namespace PassGenie
{
    partial class F_GenerateurMdp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tb_mdp = new TextBox();
            btn_generer_mdp = new Button();
            btn_copier_mdp = new Button();
            l_mdp = new Label();
            btn_valider = new Button();
            tbr_longueur = new TrackBar();
            l_longueur_valeur = new Label();
            l_symbole = new Label();
            l_chiffre = new Label();
            l_majuscule = new Label();
            l_longueur = new Label();
            l_suitelogique = new Label();
            l_motconnu = new Label();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)tbr_longueur).BeginInit();
            SuspendLayout();
            // 
            // tb_mdp
            // 
            tb_mdp.Location = new Point(12, 31);
            tb_mdp.Name = "tb_mdp";
            tb_mdp.Size = new Size(387, 23);
            tb_mdp.TabIndex = 0;
            // 
            // btn_generer_mdp
            // 
            btn_generer_mdp.Image = Properties.Resources.repeat_24;
            btn_generer_mdp.Location = new Point(405, 31);
            btn_generer_mdp.Name = "btn_generer_mdp";
            btn_generer_mdp.Size = new Size(32, 27);
            btn_generer_mdp.TabIndex = 1;
            btn_generer_mdp.UseVisualStyleBackColor = true;
            btn_generer_mdp.Click += btn_generer_mdp_Click;
            // 
            // btn_copier_mdp
            // 
            btn_copier_mdp.BackColor = SystemColors.ButtonHighlight;
            btn_copier_mdp.ForeColor = SystemColors.ControlLightLight;
            btn_copier_mdp.Image = Properties.Resources.icon_copy;
            btn_copier_mdp.Location = new Point(376, 31);
            btn_copier_mdp.Name = "btn_copier_mdp";
            btn_copier_mdp.Size = new Size(23, 23);
            btn_copier_mdp.TabIndex = 2;
            btn_copier_mdp.UseVisualStyleBackColor = false;
            btn_copier_mdp.Click += btn_copier_mdp_Click;
            // 
            // l_mdp
            // 
            l_mdp.AutoSize = true;
            l_mdp.Location = new Point(12, 9);
            l_mdp.Name = "l_mdp";
            l_mdp.Size = new Size(83, 15);
            l_mdp.TabIndex = 3;
            l_mdp.Text = "Mot de passe :";
            // 
            // btn_valider
            // 
            btn_valider.Location = new Point(325, 129);
            btn_valider.Name = "btn_valider";
            btn_valider.Size = new Size(112, 24);
            btn_valider.TabIndex = 4;
            btn_valider.Text = "Valider";
            btn_valider.UseVisualStyleBackColor = true;
            btn_valider.Click += btn_valider_Click;
            // 
            // tbr_longueur
            // 
            tbr_longueur.LargeChange = 1;
            tbr_longueur.Location = new Point(12, 78);
            tbr_longueur.Maximum = 50;
            tbr_longueur.Minimum = 12;
            tbr_longueur.Name = "tbr_longueur";
            tbr_longueur.Size = new Size(425, 45);
            tbr_longueur.TabIndex = 5;
            tbr_longueur.TickStyle = TickStyle.None;
            tbr_longueur.Value = 12;
            tbr_longueur.Scroll += tbr_longueur_Scroll;
            // 
            // l_longueur_valeur
            // 
            l_longueur_valeur.AutoSize = true;
            l_longueur_valeur.Location = new Point(12, 60);
            l_longueur_valeur.Name = "l_longueur_valeur";
            l_longueur_valeur.Size = new Size(79, 15);
            l_longueur_valeur.TabIndex = 6;
            l_longueur_valeur.Text = "Longueur : 12";
            // 
            // l_symbole
            // 
            l_symbole.AutoSize = true;
            l_symbole.Location = new Point(11, 165);
            l_symbole.Name = "l_symbole";
            l_symbole.Size = new Size(165, 15);
            l_symbole.TabIndex = 7;
            l_symbole.Text = "Dispose au moins un symbole";
            // 
            // l_chiffre
            // 
            l_chiffre.AutoSize = true;
            l_chiffre.Location = new Point(11, 190);
            l_chiffre.Name = "l_chiffre";
            l_chiffre.Size = new Size(164, 15);
            l_chiffre.TabIndex = 8;
            l_chiffre.Text = "Dispose au moins d'un chiffre";
            // 
            // l_majuscule
            // 
            l_majuscule.AutoSize = true;
            l_majuscule.Location = new Point(11, 214);
            l_majuscule.Name = "l_majuscule";
            l_majuscule.Size = new Size(190, 15);
            l_majuscule.TabIndex = 9;
            l_majuscule.Text = "Dispose au moins d'une majuscule";
            // 
            // l_longueur
            // 
            l_longueur.AutoSize = true;
            l_longueur.Location = new Point(219, 165);
            l_longueur.Name = "l_longueur";
            l_longueur.Size = new Size(230, 15);
            l_longueur.TabIndex = 10;
            l_longueur.Text = "Dispose au moins d'une douzaine de mots";
            // 
            // l_suitelogique
            // 
            l_suitelogique.AutoSize = true;
            l_suitelogique.Location = new Point(219, 214);
            l_suitelogique.Name = "l_suitelogique";
            l_suitelogique.Size = new Size(206, 15);
            l_suitelogique.TabIndex = 11;
            l_suitelogique.Text = "Ne dispose pas d'une suite de logique";
            // 
            // l_motconnu
            // 
            l_motconnu.AutoSize = true;
            l_motconnu.Location = new Point(219, 190);
            l_motconnu.Name = "l_motconnu";
            l_motconnu.Size = new Size(175, 15);
            l_motconnu.TabIndex = 12;
            l_motconnu.Text = "Ne dispose pas d'un mot connu";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // F_GenerateurMdp
            // 
            ClientSize = new Size(478, 243);
            Controls.Add(l_motconnu);
            Controls.Add(l_suitelogique);
            Controls.Add(l_longueur);
            Controls.Add(l_majuscule);
            Controls.Add(l_chiffre);
            Controls.Add(l_symbole);
            Controls.Add(l_longueur_valeur);
            Controls.Add(tbr_longueur);
            Controls.Add(btn_valider);
            Controls.Add(l_mdp);
            Controls.Add(btn_copier_mdp);
            Controls.Add(btn_generer_mdp);
            Controls.Add(tb_mdp);
            Name = "F_GenerateurMdp";
            ((System.ComponentModel.ISupportInitialize)tbr_longueur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_mdp;
        private Button btn_generer_mdp;
        private Button btn_copier_mdp;
        private Label l_mdp;
        private Button button1;
        private TrackBar tbr_longueur;
        private Label l_longueur_valeur;
        private Label l_symbole;
        private Label l_chiffre;
        private Label l_majuscule;
        private Label l_longueur;
        private Label l_suitelogique;
        private Label l_motconnu;
        private NotifyIcon notifyIcon1;
        private Button btn_valider;
    }
}
