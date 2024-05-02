using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            if (cboCidades.SelectedItem.ToString() == "Sidney")
            {
                lblResult.Text = "Você ama a cidade das praias!";
            }
            else if (cboCidades.SelectedItem.ToString() == "Paris")
            {
                lblResult.Text = "Você ama a cidade da luz!";
            }
            else if (cboCidades.SelectedItem.ToString() == "Roma")
            {
                lblResult.Text = "Você ama a cidade eterna!";
            }
            else if (cboCidades.SelectedItem.ToString() == "São Paulo")
            {
                lblResult.Text = "Você tem bom gosto para viagens";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
