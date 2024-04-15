using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class CondicionPago : Entidadbase
    {
        [Key]
        public int CondicionPagoId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        [Required]
        public int Dias { get; set; }
    }
}