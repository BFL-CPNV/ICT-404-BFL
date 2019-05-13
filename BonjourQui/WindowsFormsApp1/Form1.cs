using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BonjourQui : Form
    {
        public BonjourQui()
        {
            InitializeComponent();
        }

        private void cmdBienvenue_Click(object sender, EventArgs e)
        {
            lblNom.Text = "Bonjour " + txtInsertionNom.Text;
        }

        private void txtInsertionNom_TextChanged(object sender, EventArgs e)
        {
            cmdBienvenue.Enabled = true;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
