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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             Comentario largo de varias lineas
             

             Variables
                int 10
                decimal 10.5
                double 10.5
                string = "Juan"
                char = 'J'
                bool 
                boolean

             */

            //Comentario corto
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buenas noches"); 
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            int resultado = n1 + n2;

            txtResultado.Text = resultado.ToString();
        }
    }
}
