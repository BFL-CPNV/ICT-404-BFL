namespace CommandeDePizza
{
    partial class frmCommandeDePizza
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
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCâpres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.grpPâte = new System.Windows.Forms.GroupBox();
            this.optExtrafine = new System.Windows.Forms.RadioButton();
            this.optFine = new System.Windows.Forms.RadioButton();
            this.optNormale = new System.Windows.Forms.RadioButton();
            this.optEpaisse = new System.Windows.Forms.RadioButton();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.cmdCommander = new System.Windows.Forms.Button();
            this.lblCommande = new System.Windows.Forms.Label();
            this.txtCommande = new System.Windows.Forms.TextBox();
            this.grpPâte.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnchois.Location = new System.Drawing.Point(190, 100);
            this.chkAnchois.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(80, 22);
            this.chkAnchois.TabIndex = 0;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCâpres
            // 
            this.chkCâpres.AutoSize = true;
            this.chkCâpres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCâpres.Location = new System.Drawing.Point(190, 130);
            this.chkCâpres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCâpres.Name = "chkCâpres";
            this.chkCâpres.Size = new System.Drawing.Size(75, 22);
            this.chkCâpres.TabIndex = 1;
            this.chkCâpres.Text = "Câpres";
            this.chkCâpres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJambon.Location = new System.Drawing.Point(190, 160);
            this.chkJambon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(81, 22);
            this.chkJambon.TabIndex = 2;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrevettes.Location = new System.Drawing.Point(190, 190);
            this.chkCrevettes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(90, 22);
            this.chkCrevettes.TabIndex = 3;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // grpPâte
            // 
            this.grpPâte.Controls.Add(this.optExtrafine);
            this.grpPâte.Controls.Add(this.optFine);
            this.grpPâte.Controls.Add(this.optNormale);
            this.grpPâte.Controls.Add(this.optEpaisse);
            this.grpPâte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPâte.Location = new System.Drawing.Point(18, 68);
            this.grpPâte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPâte.Name = "grpPâte";
            this.grpPâte.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPâte.Size = new System.Drawing.Size(120, 160);
            this.grpPâte.TabIndex = 4;
            this.grpPâte.TabStop = false;
            this.grpPâte.Text = "Pâte";
            // 
            // optExtrafine
            // 
            this.optExtrafine.AutoSize = true;
            this.optExtrafine.Location = new System.Drawing.Point(8, 32);
            this.optExtrafine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optExtrafine.Name = "optExtrafine";
            this.optExtrafine.Size = new System.Drawing.Size(88, 22);
            this.optExtrafine.TabIndex = 5;
            this.optExtrafine.Text = "Extra-fine";
            this.optExtrafine.UseVisualStyleBackColor = true;
            // 
            // optFine
            // 
            this.optFine.AutoSize = true;
            this.optFine.Location = new System.Drawing.Point(8, 62);
            this.optFine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optFine.Name = "optFine";
            this.optFine.Size = new System.Drawing.Size(54, 22);
            this.optFine.TabIndex = 6;
            this.optFine.Text = "Fine";
            this.optFine.UseVisualStyleBackColor = true;
            // 
            // optNormale
            // 
            this.optNormale.AutoSize = true;
            this.optNormale.Checked = true;
            this.optNormale.Location = new System.Drawing.Point(8, 92);
            this.optNormale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optNormale.Name = "optNormale";
            this.optNormale.Size = new System.Drawing.Size(83, 22);
            this.optNormale.TabIndex = 7;
            this.optNormale.TabStop = true;
            this.optNormale.Text = "Normale";
            this.optNormale.UseVisualStyleBackColor = true;
            // 
            // optEpaisse
            // 
            this.optEpaisse.AutoSize = true;
            this.optEpaisse.Location = new System.Drawing.Point(8, 122);
            this.optEpaisse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optEpaisse.Name = "optEpaisse";
            this.optEpaisse.Size = new System.Drawing.Size(79, 22);
            this.optEpaisse.TabIndex = 8;
            this.optEpaisse.Text = "Epaisse";
            this.optEpaisse.UseVisualStyleBackColor = true;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(18, 12);
            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 18);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table";
            // 
            // txtTable
            // 
            this.txtTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTable.Location = new System.Drawing.Point(72, 9);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(45, 24);
            this.txtTable.TabIndex = 6;
            // 
            // cmdCommander
            // 
            this.cmdCommander.Location = new System.Drawing.Point(209, 253);
            this.cmdCommander.Name = "cmdCommander";
            this.cmdCommander.Size = new System.Drawing.Size(102, 28);
            this.cmdCommander.TabIndex = 7;
            this.cmdCommander.Text = "Commander";
            this.cmdCommander.UseVisualStyleBackColor = true;
            this.cmdCommander.Click += new System.EventHandler(this.cmdCommander_Click);
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Location = new System.Drawing.Point(18, 280);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(86, 18);
            this.lblCommande.TabIndex = 8;
            this.lblCommande.Text = "Commande";
            // 
            // txtCommande
            // 
            this.txtCommande.BackColor = System.Drawing.Color.Yellow;
            this.txtCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommande.Location = new System.Drawing.Point(18, 317);
            this.txtCommande.Multiline = true;
            this.txtCommande.Name = "txtCommande";
            this.txtCommande.Size = new System.Drawing.Size(293, 53);
            this.txtCommande.TabIndex = 9;
            this.txtCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCommande.Visible = false;
            // 
            // frmCommandeDePizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 388);
            this.Controls.Add(this.txtCommande);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.cmdCommander);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.grpPâte);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCâpres);
            this.Controls.Add(this.chkAnchois);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCommandeDePizza";
            this.Text = "Pizza";
            this.grpPâte.ResumeLayout(false);
            this.grpPâte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCâpres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.GroupBox grpPâte;
        private System.Windows.Forms.RadioButton optExtrafine;
        private System.Windows.Forms.RadioButton optFine;
        private System.Windows.Forms.RadioButton optNormale;
        private System.Windows.Forms.RadioButton optEpaisse;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button cmdCommander;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.TextBox txtCommande;
    }
}

