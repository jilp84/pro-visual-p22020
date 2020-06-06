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
    public partial class FrmArrays : Form
    {
        private int[] array;
        private int flag;

        public FrmArrays()
        {
            InitializeComponent();
        }

        private void FrmArrays_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearArray_Click(object sender, EventArgs e)
        {
            array = new int[int.Parse(txtTamanioArray.Text)];
            flag = 0;
            txtSalida.Text = "El array se creo con " + array.Length.ToString() + " posiciones. \n";

        }

        private void btnAgregarValor_Click(object sender, EventArgs e)
        {
            if (flag < array.Length)
            {
                array[flag] = int.Parse(txtAgregarValor.Text);
                txtSalida.Text += "Array[" + flag + "]" + " = " + array[flag].ToString() + "\n";
                flag++;
                //flag = flag + 1;
            }
            else {
                txtSalida.Text += "El Array esta lleno.";
            }


        }

        private void btnMostrarArray_Click(object sender, EventArgs e)
        {
            txtSalida.Text = "Los valores del array son los siguientes:\n";

            for (int i = 0; i < array.Length; i++)
            {
                txtSalida.Text += "Array[" + i + "]" + " = " + array[i].ToString() + "\n";
            }

        }

        private void btnMostrarArrayWhile_Click(object sender, EventArgs e)
        {
            txtSalida.Text = "Los valores del array son los siguientes:\n";

            int i = 0;

            while(i < array.Length)
            {
                txtSalida.Text += "Array[" + i + "]" + " = " + array[i].ToString() + "\n";

                i++;
            }
        }

        private void Limpiar() {
            txtSalida.Text = "";
            txtAgregarValor.Text = "";
            txtTamanioArray.Text = "";
            flag = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            txtSalida.Text = "Foreach\n";

            foreach (int item in array)
            {
                txtSalida.Text += "Array: " + item + "\n";
            }
        }
    }
}
