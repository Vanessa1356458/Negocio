using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class Producto : Entidadbase
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        public int UnidadMedidaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public decimal PrecioCompra { get; set; }
    }
}