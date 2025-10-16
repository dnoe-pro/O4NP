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
            button1 = new Button();
            tbr_longueur = new TrackBar();
            l_longueur_valeur = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            btn_copier_mdp.Image = Properties.Resources.icon_copier_24x24;
            btn_copier_mdp.Location = new Point(443, 31);
            btn_copier_mdp.Name = "btn_copier_mdp";
            btn_copier_mdp.Size = new Size(26, 29);
            btn_copier_mdp.TabIndex = 2;
            btn_copier_mdp.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Location = new Point(354, 333);
            button1.Name = "button1";
            button1.Size = new Size(112, 24);
            button1.TabIndex = 4;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbr_longueur
            // 
            tbr_longueur.LargeChange = 1;
            tbr_longueur.Location = new Point(12, 78);
            tbr_longueur.Maximum = 50;
            tbr_longueur.Minimum = 12;
            tbr_longueur.Name = "tbr_longueur";
            tbr_longueur.Size = new Size(254, 45);
            tbr_longueur.TabIndex = 5;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 126);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 7;
            label1.Text = "Dispose au moins un symbole";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 152);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 8;
            label2.Text = "Dispose au moins d'un chiffre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 177);
            label3.Name = "label3";
            label3.Size = new Size(190, 15);
            label3.TabIndex = 9;
            label3.Text = "Dispose au moins d'une majuscule";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 203);
            label4.Name = "label4";
            label4.Size = new Size(230, 15);
            label4.TabIndex = 10;
            label4.Text = "Dispose au moins d'une douzaine de mots";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 279);
            label5.Name = "label5";
            label5.Size = new Size(206, 15);
            label5.TabIndex = 11;
            label5.Text = "Ne dispose pas d'une suite de logique";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 253);
            label6.Name = "label6";
            label6.Size = new Size(175, 15);
            label6.TabIndex = 12;
            label6.Text = "Ne dispose pas d'un mot connu";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // F_GenerateurMdp
            // 
            ClientSize = new Size(478, 369);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(l_longueur_valeur);
            Controls.Add(tbr_longueur);
            Controls.Add(button1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NotifyIcon notifyIcon1;
    }
}
