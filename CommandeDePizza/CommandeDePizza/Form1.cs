//============================================
//Auteur    : Fardel Bastien
//Date      : 06.06.2019
//Version   : 1.0
//File      : CommandeDePizza
//============================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandeDePizza
{
    public partial class frmCommandeDePizza : Form
    {
        public frmCommandeDePizza()
        {
            //This is an important step since it loads the visual part (user's view) !
            InitializeComponent();
        }

        string commande_finale = "";

        private void cmdCommander_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTable.Text) || String.IsNullOrWhiteSpace(txtTable.Text))
            {
                MessageBox.Show("Veuillez insérer le numéro de votre table pour commander votre pizza.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //It isn't necessary to empty txtCommande since it won't be filled with anything if the condition above isn't filled.

            txtCommande.Text = "Pour la table " + txtTable.Text + ": pâte ";

            if (optEpaisse.Checked == true)
            {
                txtCommande.Text = txtCommande.Text + "épaisse avec ";
            }
            else
            {
                if (optExtrafine.Checked == true)
                {
                    txtCommande.Text = txtCommande.Text + "extra-fine avec ";
                }
                else
                {
                    if (optFine.Checked == true)
                    {
                        txtCommande.Text = txtCommande.Text + "fine avec ";
                    }
                    else
                    {
                        if (optNormale.Checked == true)
                        {
                            txtCommande.Text = txtCommande.Text + "normale avec ";
                        }
                    }
                }
            }

            if (chkAnchois.Checked == true)
            {
                txtCommande.Text = txtCommande.Text + "anchois,";
            }

            if (chkCâpres.Checked == true)
            {
                txtCommande.Text = txtCommande.Text + " câpres, ";
            }
                           
            if (chkJambon.Checked == true)
            {
                txtCommande.Text = txtCommande.Text + " jambon,";                   
            }
            
            if (chkCrevettes.Checked == true)
            {
                txtCommande.Text = txtCommande.Text + " crevettes,";
            }

            txtCommande.Text = txtCommande.Text.Substring(0, txtCommande.Text.Length - 1);

            txtCommande.Visible = true;


            
        }
    }
}
