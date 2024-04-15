using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class FacturaDetalle : Entidadbase
    {
        public int FacturaDetalleId { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
    }
}