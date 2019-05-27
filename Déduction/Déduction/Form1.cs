//============================================
//Auteur    : Fardel Bastien
//Date      : 27.05.2019
//Version   : 1.0
//File      : Déduction
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

namespace Déduction
{
    public partial class Déduction : Form
    {
        public Déduction()
        {
            InitializeComponent();
        }

        private void Déduction_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            Double Revenu_imposable;

            if ((String.IsNullOrEmpty(txtRevenu_brut.Text) || String.IsNullOrWhiteSpace(txtRevenu_brut.Text)) && (String.IsNullOrEmpty(txtCoefficient.Text) || String.IsNullOrWhiteSpace(txtCoefficient.Text)))
            {
                MessageBox.Show("Il va falloir remplir le coefficient et le revenu brut pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(txtRevenu_brut.Text) || String.IsNullOrWhiteSpace(txtRevenu_brut.Text))
                {
                    MessageBox.Show("Il va falloir remplir le revenu brut pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (String.IsNullOrEmpty(txtCoefficient.Text) || String.IsNullOrWhiteSpace(txtCoefficient.Text))
                    {
                        MessageBox.Show("Il va falloir remplir le coefficient pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            Revenu_imposable = (Double.Parse(txtRevenu_brut.Text) / Double.Parse(txtCoefficient.Text));

            if (chkDéduction_jeunes.Checked && chkDéduction_transport.Checked && chkRabais_fidélité.Checked)
            {
                if ((String.IsNullOrEmpty(txtDéduction_jeunes.Text) || String.IsNullOrWhiteSpace(txtDéduction_jeunes.Text)) && (String.IsNullOrEmpty(txtDéduction_transport.Text) || String.IsNullOrWhiteSpace(txtDéduction_transport.Text)) && (String.IsNullOrEmpty(txtRabais_fidélité.Text) || String.IsNullOrWhiteSpace(txtRabais_fidélité.Text)))
                {
                    MessageBox.Show("Il va falloir remplir les valeurs de vos déductions ainsi que celle de votre réduction pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (chkDéduction_jeunes.Checked && chkDéduction_transport.Checked)
            {
                if ((String.IsNullOrEmpty(txtDéduction_jeunes.Text) || String.IsNullOrWhiteSpace(txtDéduction_jeunes.Text)) && (String.IsNullOrEmpty(txtDéduction_transport.Text) || String.IsNullOrWhiteSpace(txtDéduction_transport.Text)))
                {
                    MessageBox.Show("Il va falloir remplir les valeurs de vos déductions pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (chkDéduction_jeunes.Checked && chkRabais_fidélité.Checked)
            {
                if (((String.IsNullOrEmpty(txtDéduction_jeunes.Text) || String.IsNullOrWhiteSpace(txtDéduction_jeunes.Text)) && (String.IsNullOrEmpty(txtRabais_fidélité.Text) || String.IsNullOrWhiteSpace(txtRabais_fidélité.Text))))
                {
                    MessageBox.Show("Il va falloir remplir les valeurs de votre déduction et de votre rabais pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (chkDéduction_transport.Checked && chkRabais_fidélité.Checked)
            {
                if ((String.IsNullOrEmpty(txtDéduction_transport.Text) || String.IsNullOrWhiteSpace(txtDéduction_transport.Text)) && (String.IsNullOrEmpty(txtRabais_fidélité.Text) || String.IsNullOrWhiteSpace(txtRabais_fidélité.Text)))
                {
                    MessageBox.Show("Il va falloir remplir les valeurs de votre déduction et de votre rabais pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (chkRabais_fidélité.Checked)
            {
                if (String.IsNullOrEmpty(txtRabais_fidélité.Text) || String.IsNullOrWhiteSpace(txtRabais_fidélité.Text))
                {
                    MessageBox.Show("Il va falloir remplir la valeur de votre rabais pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Revenu_imposable = Revenu_imposable - (Revenu_imposable * (Double.Parse(txtRabais_fidélité.Text) / 100));
                }
            }

            if (chkDéduction_jeunes.Checked)
            {
                if (String.IsNullOrEmpty(txtDéduction_jeunes.Text) || String.IsNullOrWhiteSpace(txtDéduction_jeunes.Text))
                {
                    MessageBox.Show("Il va falloir remplir la valeur de votre déduction pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Revenu_imposable = Revenu_imposable - Double.Parse(txtDéduction_jeunes.Text);
                }
            }

            if (chkDéduction_transport.Checked)
            {
                if (String.IsNullOrEmpty(txtDéduction_transport.Text) || String.IsNullOrWhiteSpace(txtDéduction_transport.Text))
                {
                    MessageBox.Show("Il va falloir remplir la valeur de votre déduction pour continuer.", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Revenu_imposable = Revenu_imposable - Double.Parse(txtDéduction_transport.Text);
                }
            }

            lblRevenu_Imposable.Text = "Revenu imposable : " + Convert.ToString(Revenu_imposable);

            lblRevenu_Imposable.Visible = true;
        }
    }
}

