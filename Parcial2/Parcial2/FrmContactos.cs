using Parcial2Data.Controllers;
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
        private List<Contactos> Contactos = new List<Contactos>();
        private Persona Persona;

        public FrmContactos(Persona Persona)
        {
            InitializeComponent();

            //this.Text = this.Text + Persona.NombreCompleto;
            this.Text += Persona.NombreCompleto;

            this.Persona = Persona;

            CargarListaContactos();

            CargarTipoContacto();

        }

        private void CargarTipoContacto() {

            var contactos = TipoContactoController.GetTipoContactos();

            contactos.Add( new TipoContacto { 
                
                Id = 0,
                Descripcion = "[Seleccionar]"
            
            });

            contactos = contactos.OrderBy(c => c.Descripcion).ToList();

            cmbTipoContacto.DisplayMember = "Descripcion";
            cmbTipoContacto.ValueMember = "Id";
            cmbTipoContacto.DataSource = contactos;

        }


        private void CargarListaContactos()
        {
            Contactos = PersonasCrontroller.GetContactos(Persona.Id);

            SetFuenteDatos();
        }

        private void SetFuenteDatos()
        {
            var fuente = new BindingSource();
            fuente.DataSource = Contactos;
            dgDatos.DataSource = fuente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
