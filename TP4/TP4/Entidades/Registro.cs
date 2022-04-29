using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    public class Registro
    {
        public int mes { get; set; } = 0;
        public double rnd { get; set; }
        public int demanda { get; set; }
        public double? rndDemora { get; set; }
        public int? demora { get; set; }
        public bool esperaPedido { get; set; }
        public int? llegadaPedido { get; set; }        
        public int stock { get; set; }
        public bool disponible { get; set; }
        public double costoOrdenamiento { get; set; } = 0;
        public double costoMantenimiento { get; set; } = 0;
        public double costoExterno { get; set; } = 0;
        public double total { get; set; }
        public double totalAcumulado { get; set; }
        public double minimoParcial { get; set; }
        public double maximoParcial { get; set; }
        public double promedioParcial { get; set; }
    }

}
