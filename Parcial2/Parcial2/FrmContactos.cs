using Parcial2Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class FrmContactos : Form
    {
        public FrmContactos(Persona Persona)
        {
            InitializeComponent();

            this.Text = this.Text + Persona.NombreCompleto;
            //this.Text += Persona.NombreCompleto;
        }
    }
}
