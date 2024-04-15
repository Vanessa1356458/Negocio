using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class Categoria : Entidadbase
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }
    }
}