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
        public double rndDemora { get; set; }
        public int demora { get; set; }
        public bool esperaPedido { get; set; }
        public int llegadaPedido { get; set; }
        public int disponible { get; set; }
        public int stock { get; set; }
        public double costoOrdenamiento { get; set; }
        public double costoMantenimiento { get; set; }
        public double costoExterno { get; set; }
        public double total { get; set; }
        public double totalAcumulado { get; set; }
    }

}
