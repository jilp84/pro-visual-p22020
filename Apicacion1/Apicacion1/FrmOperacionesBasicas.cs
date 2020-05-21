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
    public partial class FrmOperacionesBasicas : Form
    {
        public FrmOperacionesBasicas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var n1 = int.Parse(txtN1.Text);
            var n2 = int.Parse(txtN2.Text);

            int resultado;

            if (rbSuma.Checked)
            {
                resultado = n1 + n2;
                lblResultado.Text = resultado.ToString();
            }

            if (rbResta.Checked)
            {
                resultado = n1 - n2;
                lblResultado.Text = resultado.ToString();
            }

            if (rbDividir.Checked)
            {
                resultado = n1 / n2;
                lblResultado.Text = resultado.ToString();
            }

            if (rbMultiplicar.Checked)
            {
                resultado = n1 * n2;
                lblResultado.Text = resultado.ToString();
            }

        }
    }
}
