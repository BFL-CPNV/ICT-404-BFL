namespace WindowsFormsApp1
{
    partial class BonjourQui
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
            this.lblVotreNom = new System.Windows.Forms.Label();
            this.txtInsertionNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cmdBienvenue = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVotreNom
            // 
            this.lblVotreNom.AutoSize = true;
            this.lblVotreNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotreNom.Location = new System.Drawing.Point(81, 35);
            this.lblVotreNom.Name = "lblVotreNom";
            this.lblVotreNom.Size = new System.Drawing.Size(119, 25);
            this.lblVotreNom.TabIndex = 0;
            this.lblVotreNom.Text = "Votre nom";
            // 
            // txtInsertionNom
            // 
            this.txtInsertionNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertionNom.Location = new System.Drawing.Point(242, 35);
            this.txtInsertionNom.Name = "txtInsertionNom";
            this.txtInsertionNom.Size = new System.Drawing.Size(368, 29);
            this.txtInsertionNom.TabIndex = 1;
            this.txtInsertionNom.TextChanged += new System.EventHandler(this.txtInsertionNom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(125, 182);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 24);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = ". . .";
            // 
            // cmdBienvenue
            // 
            this.cmdBienvenue.Enabled = false;
            this.cmdBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBienvenue.Location = new System.Drawing.Point(271, 313);
            this.cmdBienvenue.Name = "cmdBienvenue";
            this.cmdBienvenue.Size = new System.Drawing.Size(217, 61);
            this.cmdBienvenue.TabIndex = 3;
            this.cmdBienvenue.Text = "Bienvenue";
            this.cmdBienvenue.UseVisualStyleBackColor = true;
            this.cmdBienvenue.Click += new System.EventHandler(this.cmdBienvenue_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.White;
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdExit.Image = global::WindowsFormsApp1.Properties.Resources.CLOSE_THE_SIMULATION;
            this.cmdExit.Location = new System.Drawing.Point(696, 342);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(70, 70);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // BonjourQui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdBienvenue);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtInsertionNom);
            this.Controls.Add(this.lblVotreNom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BonjourQui";
            this.Text = "Bonjour Qui ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVotreNom;
        private System.Windows.Forms.TextBox txtInsertionNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button cmdBienvenue;
        private System.Windows.Forms.Button cmdExit;
    }
}

