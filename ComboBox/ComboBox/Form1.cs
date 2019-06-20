using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboFAI.Items.Add("Swisscom");
            cboEcoles.Items.Add("CEPM");
            cboEcoles.Items.Add("CPNV");
            cboEcoles.Items.Add("ECL");
            cboEcoles.Items.Add("EPCL");
            cboEcoles.Items.Add("EPSIC");
            cboEcoles.Items.Add("ETML");
            cboGymnases.Items.Add("Gymnase du Bugnon");
            cboGymnases.Items.Add("Gymnase de Beaulieu");
            cboGymnases.Items.Add("Gymnase d'Yverdon");
        }
    }
}
