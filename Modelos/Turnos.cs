using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVirtual.Modelos
{
    public class Turnos
    {
        public int TurnoId { get; set; }
    
        public int EsApertura { get; set; }

        public int Año { get; set; }

        public DateOnly Desde { get; set; }

        public DateOnly Hasta { get; set; }

        public int Turno { get; set; }

    }
}
