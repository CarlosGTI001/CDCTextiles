using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCT.Models
{
    public class PedidosDetalle
    {
        [Display(Name = "Track")]
        public string codigoRastreo { get; set; }

        [Display(Name = "Estado")]
        public string estadoPedido { get; set; }

        [Display(Name = "Tipo")]
        public string tipoPedido { get; set; }

        [Display(Name = "Fecha")]
        public DateTime fechaActualizado { get; set; } 
    }
}
