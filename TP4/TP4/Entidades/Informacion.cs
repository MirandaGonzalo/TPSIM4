using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    public class Informacion
    {
        public int pedido { get; set; } = 20;
        public int condicionPedido { get; set; } = 12;
        public double costoOrdenamiento { get; set; } = 570;
        public double costoAlmacenamiento { get; set; } = 600;
        public double ventaPerdida { get; set; } = 4350;
        
    }
}