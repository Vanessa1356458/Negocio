using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class GrupoDescuento : Entidadbase
    {
        [Key]
        public int GrupoDescuentoId { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public decimal Porcentaje { get; set; }

    }
}