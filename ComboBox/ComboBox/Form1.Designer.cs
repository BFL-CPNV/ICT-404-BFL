namespace ComboBox
{
    partial class frmComboBox
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
            this.cboFAI = new System.Windows.Forms.ComboBox();
            this.cboGymnases = new System.Windows.Forms.ComboBox();
            this.cboEcoles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboFAI
            // 
            this.cboFAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFAI.ForeColor = System.Drawing.Color.Red;
            this.cboFAI.FormattingEnabled = true;
            this.cboFAI.Location = new System.Drawing.Point(31, 38);
            this.cboFAI.Name = "cboFAI";
            this.cboFAI.Size = new System.Drawing.Size(148, 26);
            this.cboFAI.TabIndex = 0;
            // 
            // cboGymnases
            // 
            this.cboGymnases.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGymnases.ForeColor = System.Drawing.Color.Fuchsia;
            this.cboGymnases.FormattingEnabled = true;
            this.cboGymnases.Location = new System.Drawing.Point(31, 394);
            this.cboGymnases.Name = "cboGymnases";
            this.cboGymnases.Size = new System.Drawing.Size(148, 26);
            this.cboGymnases.TabIndex = 1;
            // 
            // cboEcoles
            // 
            this.cboEcoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEcoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEcoles.ForeColor = System.Drawing.Color.Green;
            this.cboEcoles.FormattingEnabled = true;
            this.cboEcoles.Location = new System.Drawing.Point(31, 102);
            this.cboEcoles.Name = "cboEcoles";
            this.cboEcoles.Size = new System.Drawing.Size(148, 260);
            this.cboEcoles.TabIndex = 2;
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 579);
            this.Controls.Add(this.cboEcoles);
            this.Controls.Add(this.cboGymnases);
            this.Controls.Add(this.cboFAI);
            this.Name = "frmComboBox";
            this.Text = "ListeBox et ComboBox avec des styles différents";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFAI;
        private System.Windows.Forms.ComboBox cboGymnases;
        private System.Windows.Forms.ComboBox cboEcoles;
    }
}

