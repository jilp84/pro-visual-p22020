﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    public class Persona
    {
        //Propiedad
        public string Id { get; set; }

        [Browsable(false)]
        public string Nombres { get; set; }

        [Browsable(false)]
        public string Apellidos { get; set; }

        [DisplayName("Nombre")]
        public string NombreCompleto {
            get {

                return Nombres + " " + Apellidos;

            }
        }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }


        public int Edad {
            get {                
                return DateTime.Now.Year - FechaNacimiento.Year;
            }
        }

        //Metodos

        public void test() {
            string fullname = this.NombreCompleto;
        }

    }
}
