using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Data.Models
{
    public class Contactos
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Contacto")]
        public string Descripcion { get; set; }
        [Browsable(false)]
        public int PersonaId { get; set; }
        [Browsable(false)]
        public string PersonaNombre { get; set; }
        [Browsable(false)]
        public int TipoContactoId { get; set; }
        [DisplayName("Tipo de Contacto")]
        public string TipoContactoNombre { get; set; }

    }
}
