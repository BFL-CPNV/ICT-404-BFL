namespace Déduction
{
    partial class Déduction
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
            this.lblRevenu_brut = new System.Windows.Forms.Label();
            this.lblCoefficient = new System.Windows.Forms.Label();
            this.txtRevenu_brut = new System.Windows.Forms.TextBox();
            this.txtCoefficient = new System.Windows.Forms.TextBox();
            this.chkDéduction_jeunes = new System.Windows.Forms.CheckBox();
            this.chkDéduction_transport = new System.Windows.Forms.CheckBox();
            this.chkRabais_fidélité = new System.Windows.Forms.CheckBox();
            this.txtDéduction_jeunes = new System.Windows.Forms.TextBox();
            this.txtDéduction_transport = new System.Windows.Forms.TextBox();
            this.txtRabais_fidélité = new System.Windows.Forms.TextBox();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.lblRevenu_Imposable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRevenu_brut
            // 
            this.lblRevenu_brut.AutoSize = true;
            this.lblRevenu_brut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenu_brut.ForeColor = System.Drawing.Color.White;
            this.lblRevenu_brut.Location = new System.Drawing.Point(14, 34);
            this.lblRevenu_brut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRevenu_brut.Name = "lblRevenu_brut";
            this.lblRevenu_brut.Size = new System.Drawing.Size(166, 20);
            this.lblRevenu_brut.TabIndex = 0;
            this.lblRevenu_brut.Text = "Revenu annuel brut";
            // 
            // lblCoefficient
            // 
            this.lblCoefficient.AutoSize = true;
            this.lblCoefficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoefficient.ForeColor = System.Drawing.Color.White;
            this.lblCoefficient.Location = new System.Drawing.Point(14, 92);
            this.lblCoefficient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCoefficient.Name = "lblCoefficient";
            this.lblCoefficient.Size = new System.Drawing.Size(157, 20);
            this.lblCoefficient.TabIndex = 0;
            this.lblCoefficient.Text = "Coefficient familial";
            // 
            // txtRevenu_brut
            // 
            this.txtRevenu_brut.Location = new System.Drawing.Point(232, 28);
            this.txtRevenu_brut.Name = "txtRevenu_brut";
            this.txtRevenu_brut.Size = new System.Drawing.Size(213, 26);
            this.txtRevenu_brut.TabIndex = 1;
            this.txtRevenu_brut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCoefficient
            // 
            this.txtCoefficient.AcceptsTab = true;
            this.txtCoefficient.Location = new System.Drawing.Point(374, 83);
            this.txtCoefficient.Name = "txtCoefficient";
            this.txtCoefficient.Size = new System.Drawing.Size(71, 26);
            this.txtCoefficient.TabIndex = 2;
            this.txtCoefficient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkDéduction_jeunes
            // 
            this.chkDéduction_jeunes.AutoSize = true;
            this.chkDéduction_jeunes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chkDéduction_jeunes.ForeColor = System.Drawing.Color.White;
            this.chkDéduction_jeunes.Location = new System.Drawing.Point(18, 186);
            this.chkDéduction_jeunes.Name = "chkDéduction_jeunes";
            this.chkDéduction_jeunes.Size = new System.Drawing.Size(168, 24);
            this.chkDéduction_jeunes.TabIndex = 3;
            this.chkDéduction_jeunes.Text = "Déduction jeunes";
            this.chkDéduction_jeunes.UseVisualStyleBackColor = false;
            // 
            // chkDéduction_transport
            // 
            this.chkDéduction_transport.AutoSize = true;
            this.chkDéduction_transport.Location = new System.Drawing.Point(18, 227);
            this.chkDéduction_transport.Name = "chkDéduction_transport";
            this.chkDéduction_transport.Size = new System.Drawing.Size(188, 24);
            this.chkDéduction_transport.TabIndex = 4;
            this.chkDéduction_transport.Text = "Déduction transport";
            this.chkDéduction_transport.UseVisualStyleBackColor = true;
            // 
            // chkRabais_fidélité
            // 
            this.chkRabais_fidélité.AutoSize = true;
            this.chkRabais_fidélité.Location = new System.Drawing.Point(18, 268);
            this.chkRabais_fidélité.Name = "chkRabais_fidélité";
            this.chkRabais_fidélité.Size = new System.Drawing.Size(175, 24);
            this.chkRabais_fidélité.TabIndex = 5;
            this.chkRabais_fidélité.Text = "Rabais fidélité (%)";
            this.chkRabais_fidélité.UseVisualStyleBackColor = true;
            // 
            // txtDéduction_jeunes
            // 
            this.txtDéduction_jeunes.AcceptsTab = true;
            this.txtDéduction_jeunes.Location = new System.Drawing.Point(374, 181);
            this.txtDéduction_jeunes.Name = "txtDéduction_jeunes";
            this.txtDéduction_jeunes.Size = new System.Drawing.Size(71, 26);
            this.txtDéduction_jeunes.TabIndex = 6;
            this.txtDéduction_jeunes.Text = "900";
            this.txtDéduction_jeunes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDéduction_transport
            // 
            this.txtDéduction_transport.AcceptsTab = true;
            this.txtDéduction_transport.Location = new System.Drawing.Point(374, 222);
            this.txtDéduction_transport.Name = "txtDéduction_transport";
            this.txtDéduction_transport.Size = new System.Drawing.Size(71, 26);
            this.txtDéduction_transport.TabIndex = 7;
            this.txtDéduction_transport.Text = "650";
            this.txtDéduction_transport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRabais_fidélité
            // 
            this.txtRabais_fidélité.AcceptsTab = true;
            this.txtRabais_fidélité.Location = new System.Drawing.Point(374, 263);
            this.txtRabais_fidélité.Name = "txtRabais_fidélité";
            this.txtRabais_fidélité.Size = new System.Drawing.Size(71, 26);
            this.txtRabais_fidélité.TabIndex = 8;
            this.txtRabais_fidélité.Text = "0";
            this.txtRabais_fidélité.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdCalcul.Image = global::Déduction.Properties.Resources.Calculatrice;
            this.cmdCalcul.Location = new System.Drawing.Point(183, 324);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(94, 39);
            this.cmdCalcul.TabIndex = 9;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdCalcul.UseVisualStyleBackColor = false;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // lblRevenu_Imposable
            // 
            this.lblRevenu_Imposable.AutoSize = true;
            this.lblRevenu_Imposable.Location = new System.Drawing.Point(31, 406);
            this.lblRevenu_Imposable.Name = "lblRevenu_Imposable";
            this.lblRevenu_Imposable.Size = new System.Drawing.Size(24, 20);
            this.lblRevenu_Imposable.TabIndex = 10;
            this.lblRevenu_Imposable.Text = "...";
            this.lblRevenu_Imposable.Visible = false;
            // 
            // Déduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(457, 445);
            this.Controls.Add(this.lblRevenu_Imposable);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.txtRabais_fidélité);
            this.Controls.Add(this.txtDéduction_transport);
            this.Controls.Add(this.txtDéduction_jeunes);
            this.Controls.Add(this.chkRabais_fidélité);
            this.Controls.Add(this.chkDéduction_transport);
            this.Controls.Add(this.chkDéduction_jeunes);
            this.Controls.Add(this.txtCoefficient);
            this.Controls.Add(this.txtRevenu_brut);
            this.Controls.Add(this.lblCoefficient);
            this.Controls.Add(this.lblRevenu_brut);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Déduction";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.Déduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenu_brut;
        private System.Windows.Forms.Label lblCoefficient;
        private System.Windows.Forms.TextBox txtRevenu_brut;
        private System.Windows.Forms.TextBox txtCoefficient;
        private System.Windows.Forms.CheckBox chkDéduction_jeunes;
        private System.Windows.Forms.CheckBox chkDéduction_transport;
        private System.Windows.Forms.CheckBox chkRabais_fidélité;
        private System.Windows.Forms.TextBox txtDéduction_jeunes;
        private System.Windows.Forms.TextBox txtDéduction_transport;
        private System.Windows.Forms.TextBox txtRabais_fidélité;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Label lblRevenu_Imposable;
    }
}

