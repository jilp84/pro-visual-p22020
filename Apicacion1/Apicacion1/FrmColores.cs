using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apicacion1
{
    public partial class FrmColores : Form
    {
        public FrmColores()
        {
            InitializeComponent();
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            if (cmbColores.SelectedItem.ToString() == "Rojo" || rbRojo.Checked)
            {
                pnlColor.BackColor = Color.Red;
                limpiarControles();
            }
            else if (cmbColores.SelectedItem.ToString() == "Amarillo" || RbAmarillo.Checked)
            {
                pnlColor.BackColor = Color.Yellow;
                limpiarControles();
            }
            else if (cmbColores.SelectedItem.ToString() == "Azul" || rbAzul.Checked)
            {
                pnlColor.BackColor = Color.Blue;
                limpiarControles();

            }

        }

        private void limpiarControles()
        {
            rbRojo.Checked = false;
            RbAmarillo.Checked = false;
            rbAzul.Checked = false;
        }

        private void btnSetColorRB_Click(object sender, EventArgs e)
        {

        }
    }
}
