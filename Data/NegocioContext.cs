using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Negocio.Data
{
    public class TiendaContex : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TiendaContex() : base("name=Tiendafactura")
        {
        }

        public System.Data.Entity.DbSet<Negocio.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<Negocio.Models.UnidadMedida> UnidadMedidas { get; set; }

        public System.Data.Entity.DbSet<Negocio.Models.GrupoDescuento> GrupoDescuentoes { get; set; }

        public System.Data.Entity.DbSet<Negocio.Models.CondicionPago> CondicionPagoes { get; set; }

        public System.Data.Entity.DbSet<Negocio.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<Negocio.Models.Producto> Productoes { get; set; }
    }
}
