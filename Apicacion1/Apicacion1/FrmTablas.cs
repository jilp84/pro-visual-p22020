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
    public partial class FrmTablas : Form
    {
        public FrmTablas()
        {
            InitializeComponent();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            var tabla = int.Parse(txtTabla.Text);
            var limite = int.Parse(txtLimite.Text);
            txtResultados.Text = "Tabla desde Ciclo For:\n";
            
            for (int i = 1; i <= limite; i++)
            {
                int respuesta = i * tabla;
                txtResultados.Text += tabla.ToString() + " x " + i.ToString() + " = " + respuesta.ToString() + "\n"; 
            }

        }

        private void btnMostrarTablaWhile_Click(object sender, EventArgs e)
        {
            var tabla = int.Parse(txtTabla.Text);
            var limite = int.Parse(txtLimite.Text);

            txtResultados.Text = "Tabla desde Ciclo While:\n";

            int i = 1;

            while (i <= limite)
            {
                int respuesta = i * tabla;
                txtResultados.Text += tabla.ToString() + " x " + i.ToString() + " = " + respuesta.ToString() + "\n";

                i++;
            }

        }
    }
}
