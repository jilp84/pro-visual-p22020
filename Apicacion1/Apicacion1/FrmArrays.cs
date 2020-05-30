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
            if (flag < int.Parse(txtTamanioArray.Text))
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
    }
}
