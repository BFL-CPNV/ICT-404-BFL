namespace ArcheDeNoé
{
    partial class frmArcheDeNoé
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
            this.components = new System.ComponentModel.Container();
            this.lblEncoreATerre = new System.Windows.Forms.Label();
            this.lstEncoreATerre = new System.Windows.Forms.ListBox();
            this.lstABord = new System.Windows.Forms.ListBox();
            this.lblABord = new System.Windows.Forms.Label();
            this.cmdFleche1 = new System.Windows.Forms.Button();
            this.cmdFleche2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEncoreATerre
            // 
            this.lblEncoreATerre.AutoSize = true;
            this.lblEncoreATerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncoreATerre.Location = new System.Drawing.Point(31, 30);
            this.lblEncoreATerre.Name = "lblEncoreATerre";
            this.lblEncoreATerre.Size = new System.Drawing.Size(162, 25);
            this.lblEncoreATerre.TabIndex = 0;
            this.lblEncoreATerre.Text = "Encore à terre";
            // 
            // lstEncoreATerre
            // 
            this.lstEncoreATerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEncoreATerre.FormattingEnabled = true;
            this.lstEncoreATerre.ItemHeight = 18;
            this.lstEncoreATerre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Cheval",
            "Chien",
            "Cobra",
            "Coccinelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.lstEncoreATerre.Location = new System.Drawing.Point(34, 61);
            this.lstEncoreATerre.Name = "lstEncoreATerre";
            this.lstEncoreATerre.Size = new System.Drawing.Size(271, 526);
            this.lstEncoreATerre.Sorted = true;
            this.lstEncoreATerre.TabIndex = 1;
            // 
            // lstABord
            // 
            this.lstABord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstABord.FormattingEnabled = true;
            this.lstABord.ItemHeight = 18;
            this.lstABord.Location = new System.Drawing.Point(473, 61);
            this.lstABord.Name = "lstABord";
            this.lstABord.Size = new System.Drawing.Size(271, 526);
            this.lstABord.TabIndex = 2;
            this.lstABord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstABord_MouseDoubleClick);
            // 
            // lblABord
            // 
            this.lblABord.AutoSize = true;
            this.lblABord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABord.Location = new System.Drawing.Point(468, 30);
            this.lblABord.Name = "lblABord";
            this.lblABord.Size = new System.Drawing.Size(81, 25);
            this.lblABord.TabIndex = 3;
            this.lblABord.Text = "A bord";
            // 
            // cmdFleche1
            // 
            this.cmdFleche1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFleche1.Location = new System.Drawing.Point(311, 174);
            this.cmdFleche1.Name = "cmdFleche1";
            this.cmdFleche1.Size = new System.Drawing.Size(156, 39);
            this.cmdFleche1.TabIndex = 4;
            this.cmdFleche1.Text = "===>";
            this.cmdFleche1.UseVisualStyleBackColor = true;
            this.cmdFleche1.Click += new System.EventHandler(this.cmdFleche1_Click);
            // 
            // cmdFleche2
            // 
            this.cmdFleche2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFleche2.Location = new System.Drawing.Point(311, 238);
            this.cmdFleche2.Name = "cmdFleche2";
            this.cmdFleche2.Size = new System.Drawing.Size(156, 39);
            this.cmdFleche2.TabIndex = 5;
            this.cmdFleche2.Text = "<===";
            this.cmdFleche2.UseVisualStyleBackColor = true;
            this.cmdFleche2.Click += new System.EventHandler(this.cmdFleche2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmArcheDeNoé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 644);
            this.Controls.Add(this.cmdFleche2);
            this.Controls.Add(this.cmdFleche1);
            this.Controls.Add(this.lblABord);
            this.Controls.Add(this.lstABord);
            this.Controls.Add(this.lstEncoreATerre);
            this.Controls.Add(this.lblEncoreATerre);
            this.Name = "frmArcheDeNoé";
            this.Text = "Arche de Noé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncoreATerre;
        private System.Windows.Forms.ListBox lstEncoreATerre;
        private System.Windows.Forms.ListBox lstABord;
        private System.Windows.Forms.Label lblABord;
        private System.Windows.Forms.Button cmdFleche1;
        private System.Windows.Forms.Button cmdFleche2;
        private System.Windows.Forms.Timer timer1;
    }
}

