using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Negocio.Models
{
    public class Entidadbase
    {
        [Display(Name = "Fecha Creacion")]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Fecha Modificacion")]
        public DateTime FechaModificacion { get; set; }
    }
}