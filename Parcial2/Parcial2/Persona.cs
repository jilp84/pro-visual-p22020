using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    public class Persona
    {
        //Propiedad
        public string Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string NombreCompleto {
            get {

                return Nombres + " " + Apellidos;

            }
        }

        //Metodos

        public void test() {
            string fullname = this.NombreCompleto;
        }

    }
}
