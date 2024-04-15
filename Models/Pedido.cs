using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class Pedido : Entidadbase
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
    }
}