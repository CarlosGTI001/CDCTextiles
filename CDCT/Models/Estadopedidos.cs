using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCT.Models
{
    internal class Estadopedidos
    {
        public int _Facturados { get; set; }
        public int _Procesando { get; set; }
        public int _Entregados { get; set; }
        public int _Enviado { get; set; }
    }
}
