//============================================
//Auteur    : Fardel Bastien
//Date      : 03.06.2019
//Version   : 1.0
//File      : FenetreBleuRouge
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

namespace FenetreBleuRouge
{
    public partial class Fenetre : Form
    {
        int moved = 0;
        int color_changed = 0;

        public Fenetre()
        {
            InitializeComponent();
        }

        private void cmdBleu_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Blue)
            {
                //Do nothing
            }
            else
            {
                this.BackColor = Color.Blue;
                color_changed = color_changed + 1;
            }

        }

        private void cmdRouge_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                //Do nothing
            }
            else
            { 
                this.BackColor = Color.Red;
                color_changed = color_changed + 1;
            }
        }

        private void cmdHautGauche_Click(object sender, EventArgs e)
        {
            this.SetBounds (-10 , 0, 500, 406);
            moved = moved + 1;
        }

        private void cmdHautDroite_Click(object sender, EventArgs e)
        {
            this.SetBounds (1430, 0, 500, 406);
            moved = moved + 1;
        }

        private void cmdBasGauche_Click(object sender, EventArgs e)
        {
            this.SetBounds (-10, 640, 500, 406);
            moved = moved + 1;
        }

        private void cmdBasDroite_Click(object sender, EventArgs e)
        {
            this.SetBounds (1430, 640, 500, 406);
            moved = moved + 1;
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(moved) + " déplacement(s), " + Convert.ToString(color_changed) + " changement(s) de couleur.");
        }
    }
}
