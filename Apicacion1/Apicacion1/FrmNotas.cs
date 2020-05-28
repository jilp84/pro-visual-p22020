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
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void btnCalcularProm_Click(object sender, EventArgs e)
        {
            var n1 = float.Parse(txtN1.Text);
            var n2 = float.Parse(txtN2.Text);
            var n3 = float.Parse(txtN3.Text);

            float prom = (n1+n2+n3) / 3;

            if (prom < 70)
            {
                txtResultado.BackColor = Color.Red;
                txtResultado.Text = prom.ToString();
            }
            else
            {
                txtResultado.BackColor = Color.Green;
                txtResultado.Text = prom.ToString();
            }


        }
    }
}
