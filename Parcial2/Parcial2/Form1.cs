using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2Data.Models;
using Parcial2Data.Controllers;

namespace Parcial2
{
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();

            CargarListaPersonas();
        }

        private void CargarListaPersonas() {
            personas = PersonasCrontroller.GetPersonas();

            SetFuenteDatos();
        }

        private void SetFuenteDatos() {
            var fuente = new BindingSource();
            fuente.DataSource = personas;
            dgDatos.DataSource = fuente;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //int promedio = 0;
            //Persona persona1 = new Persona();
            //Persona persona2 = new Persona();

            //persona1.Id = "0401-1998-00041";

            //persona1.Nombres = "Juan";
            //persona1.Apellidos = "Perez";


            //persona2.Id = "0415-2000-00158";

            //MessageBox.Show(
            //    "P1 Id:" + persona1.Id + "\n" +
            //     "P2 Id:" + persona2.Id);

            //MessageBox.Show("Nombre completo P1: " + persona1.NombreCompleto);
            //MessageBox.Show("Nombre completo P2: " + persona2.NombreCompleto);


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            personas.Add(
                new Persona {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Id = int.Parse(txtId.Text),
                    FechaNacimiento = cmbFechaNacimiento.Value.Date
                }
            );
            limpiar();

            var fuente = new BindingSource();
            fuente.DataSource = personas;
            dgDatos.DataSource = fuente;
        }

        void limpiar() {
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
        }
    }
}
