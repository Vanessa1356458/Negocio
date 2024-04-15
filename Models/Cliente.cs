using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class Cliente: Entidadbase
    {
        [Key]
        public int ClienteI { get; set; }

        [Required]
        [StringLength(15)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        public int GrupoDescuentoId { get; set; }
        public int CondicionPagoId { get; set; }
        public bool Estado { get; set; }
    }
}