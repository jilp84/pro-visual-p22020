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
    public partial class FrmSwitch : Form
    {
        public FrmSwitch()
        {
            InitializeComponent();
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);

            switch (dia)
            {
                case 1: 
                    lblDia.Text = "Domingo";
                    break;
                case 2:
                    lblDia.Text = "Lunes";
                    break;
                case 3:
                    lblDia.Text = "Martes";
                    break;
                case 4:
                    lblDia.Text = "Miercoles";
                    break;
                case 5:
                    lblDia.Text = "Jueves";
                    break;
                case 6:
                    lblDia.Text = "Viernes";
                    break;
                case 7:
                    lblDia.Text = "Sabado";
                    break;
                default:
                    lblDia.Text = "Fuera de rango";
                    break;
            }
        }
    }
}
