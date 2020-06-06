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
    public partial class FrmFactura : Form
    {
        double[,] factura;
        int flag;
        int cantidadProductos;
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            cantidadProductos = int.Parse(txtCrearFactura.Text);

            factura = new double[cantidadProductos, 3];

            flag = 0;

            txtSalida.Text = "Matriz iniciada.";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtCantidad.Text);
            double precio = double.Parse(txtPrecio.Text);

            factura[flag, 0] = cantidad;
            factura[flag, 1] = precio;
            factura[flag, 2] = cantidad * precio;

            txtSalida.Text += "Producto: " + flag + " Cantidad: " + factura[flag, 0] + " Precio: " + factura[flag, 1] + " Sub-Total: " + factura[flag, 2] + "\n";

            flag++;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtSalida.Text = "Impresión de Factura (Ciclo For)";

            double total = 0;

            for (int i = 0; i < cantidadProductos; i++)
            {
                //for (int j = 0; j < 2; j++)
                //{
                    txtSalida.Text += "Producto: " + i + " Cantidad: " + factura[i, 0] + " Precio: " + factura[i, 1] + " Sub-Total: " + factura[i, 2] + "\n";
                    total += factura[i, 2];
                //}
            }
            txtSalida.Text += "\n\n";
            txtSalida.Text += "El total de la factura es: L." + total + "\n";
        }

        private void btnImprimirWhile_Click(object sender, EventArgs e)
        {
            txtSalida.Text = "Impresión de Factura (Ciclo While)";

            double total = 0;
            int i=0;

            while (i<cantidadProductos)
            {
                txtSalida.Text += "Producto: " + i + " Cantidad: " + factura[i, 0] + " Precio: " + factura[i, 1] + " Sub-Total: " + factura[i, 2] + "\n";
                total += factura[i, 2];

                i++;
            }
            txtSalida.Text += "\n\n";
            txtSalida.Text += "El total de la factura es: L." + total + "\n";

        }
    }
}
