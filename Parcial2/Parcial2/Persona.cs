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
