//============================================
//Auteur    : Fardel Bastien
//Date      : 13.06.2019
//Version   : 1.0
//File      : ArcheDeNoé
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

namespace ArcheDeNoé
{
    public partial class frmArcheDeNoé : Form
    {
        public frmArcheDeNoé()
        {
            InitializeComponent();
        }

        private void cmdFleche1_Click(object sender, EventArgs e)
        {
            if (lstEncoreATerre.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un élement de la liste de gauche pour continuer.", "Erreur", MessageBoxButtons.OK);
                return;
            }
            //Users won't be able to do anything as long as they don't choose an element from the corresponding list.

            lstABord.Items.Add(lstEncoreATerre.SelectedItem);
            lstEncoreATerre.Items.Remove(lstEncoreATerre.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lstABord.Items.Count == 0)
            {
                cmdFleche2.Enabled = false;
            }
            else
            {
                cmdFleche2.Enabled = true;
            }

            if (lstEncoreATerre.Items.Count == 0)
            {
                cmdFleche1.Enabled = false;
            }
            else
            {
                cmdFleche1.Enabled = true;
            }        
        }

        private void cmdFleche2_Click(object sender, EventArgs e)
        {
            if (lstABord.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir un élement de la liste de droite pour continuer.", "Erreur", MessageBoxButtons.OK);
                return;
            }
            //Users won't be able to do anything as long as they don't choose an element from the corresponding list.

            lstEncoreATerre.Items.Add(lstABord.SelectedItem);
            lstABord.Items.Remove(lstABord.SelectedItem);
        }

        private void lstABord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // lstEncoreATerre.Items.Add(lstABord.Items);
            //lstABord.Items.Remove(lstABord.Items);
        }
    }
}
