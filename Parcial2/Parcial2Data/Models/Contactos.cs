using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Data.Models
{
    public class Contactos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int PersonaId { get; set; }
        public string PersonaNombre { get; set; }
        public int TipoContactoId { get; set; }
        public string TipoContactoNombre { get; set; }

    }
}
