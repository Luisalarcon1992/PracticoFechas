using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Periodo
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }

        public Periodo(DateTime FechaInicial, DateTime FechaUltima)
        {
            this.FechaInicio = FechaInicial;
            this.FechaFinal = FechaUltima;
        }

        public int EspacioTiempo()
        {
            return (this.FechaFinal - this.FechaInicio).Days;
        }


    }
}
