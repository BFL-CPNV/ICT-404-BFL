namespace FenetreBleuRouge
{
    partial class Fenetre
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdHautGauche = new System.Windows.Forms.Button();
            this.cmdHautDroite = new System.Windows.Forms.Button();
            this.cmdBleu = new System.Windows.Forms.Button();
            this.cmdRouge = new System.Windows.Forms.Button();
            this.cmdStats = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdBasDroite = new System.Windows.Forms.Button();
            this.cmdBasGauche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdHautGauche
            // 
            this.cmdHautGauche.Location = new System.Drawing.Point(12, 12);
            this.cmdHautGauche.Name = "cmdHautGauche";
            this.cmdHautGauche.Size = new System.Drawing.Size(115, 30);
            this.cmdHautGauche.TabIndex = 0;
            this.cmdHautGauche.Text = "Haut/Gauche";
            this.cmdHautGauche.UseVisualStyleBackColor = true;
            this.cmdHautGauche.Click += new System.EventHandler(this.cmdHautGauche_Click);
            // 
            // cmdHautDroite
            // 
            this.cmdHautDroite.Location = new System.Drawing.Point(357, 12);
            this.cmdHautDroite.Name = "cmdHautDroite";
            this.cmdHautDroite.Size = new System.Drawing.Size(115, 30);
            this.cmdHautDroite.TabIndex = 1;
            this.cmdHautDroite.Text = "Haut/Droite";
            this.cmdHautDroite.UseVisualStyleBackColor = true;
            this.cmdHautDroite.Click += new System.EventHandler(this.cmdHautDroite_Click);
            // 
            // cmdBleu
            // 
            this.cmdBleu.Location = new System.Drawing.Point(184, 78);
            this.cmdBleu.Name = "cmdBleu";
            this.cmdBleu.Size = new System.Drawing.Size(115, 27);
            this.cmdBleu.TabIndex = 2;
            this.cmdBleu.Text = "Bleu";
            this.cmdBleu.UseVisualStyleBackColor = true;
            this.cmdBleu.Click += new System.EventHandler(this.cmdBleu_Click);
            // 
            // cmdRouge
            // 
            this.cmdRouge.Location = new System.Drawing.Point(184, 111);
            this.cmdRouge.Name = "cmdRouge";
            this.cmdRouge.Size = new System.Drawing.Size(115, 30);
            this.cmdRouge.TabIndex = 3;
            this.cmdRouge.Text = "Rouge";
            this.cmdRouge.UseVisualStyleBackColor = true;
            this.cmdRouge.Click += new System.EventHandler(this.cmdRouge_Click);
            // 
            // cmdStats
            // 
            this.cmdStats.Location = new System.Drawing.Point(184, 208);
            this.cmdStats.Name = "cmdStats";
            this.cmdStats.Size = new System.Drawing.Size(115, 30);
            this.cmdStats.TabIndex = 4;
            this.cmdStats.Text = "Stats";
            this.cmdStats.UseVisualStyleBackColor = true;
            this.cmdStats.Click += new System.EventHandler(this.cmdStats_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(184, 244);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(115, 30);
            this.cmdQuitter.TabIndex = 5;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdBasDroite
            // 
            this.cmdBasDroite.Location = new System.Drawing.Point(357, 325);
            this.cmdBasDroite.Name = "cmdBasDroite";
            this.cmdBasDroite.Size = new System.Drawing.Size(115, 30);
            this.cmdBasDroite.TabIndex = 6;
            this.cmdBasDroite.Text = "Bas/Droite";
            this.cmdBasDroite.UseVisualStyleBackColor = true;
            this.cmdBasDroite.Click += new System.EventHandler(this.cmdBasDroite_Click);
            // 
            // cmdBasGauche
            // 
            this.cmdBasGauche.Location = new System.Drawing.Point(12, 325);
            this.cmdBasGauche.Name = "cmdBasGauche";
            this.cmdBasGauche.Size = new System.Drawing.Size(115, 30);
            this.cmdBasGauche.TabIndex = 7;
            this.cmdBasGauche.Text = "Bas/Gauche";
            this.cmdBasGauche.UseVisualStyleBackColor = true;
            this.cmdBasGauche.Click += new System.EventHandler(this.cmdBasGauche_Click);
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 367);
            this.Controls.Add(this.cmdBasGauche);
            this.Controls.Add(this.cmdBasDroite);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdStats);
            this.Controls.Add(this.cmdRouge);
            this.Controls.Add(this.cmdBleu);
            this.Controls.Add(this.cmdHautDroite);
            this.Controls.Add(this.cmdHautGauche);
            this.Name = "Fenetre";
            this.Text = "Fenêtre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdHautGauche;
        private System.Windows.Forms.Button cmdHautDroite;
        private System.Windows.Forms.Button cmdBleu;
        private System.Windows.Forms.Button cmdRouge;
        private System.Windows.Forms.Button cmdStats;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdBasDroite;
        private System.Windows.Forms.Button cmdBasGauche;
    }
}

