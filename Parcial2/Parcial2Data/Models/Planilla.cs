using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Data.Models
{
    public class Planilla
    {
        public int NumeroPlanilla { get; set; }
        public DateTime Fecha { get; set; }
        public string Empresa { get; set; }
        public string TipoPlanilla { get; set; }

        List<Persona> Empleados { get; set; } 

        public decimal TotalPlanilla { get; set; }

    }
}
