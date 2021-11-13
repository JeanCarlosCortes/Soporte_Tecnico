using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanCarlosCortes
{
    public class Tickets
    {
        public string Nombre { get; set; }
        public string Tipo_servicio { get; set; }
        public string Sistema_operativo { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }

    }
}
