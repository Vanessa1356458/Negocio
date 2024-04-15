namespace Negocio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionTablaCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 150),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteI = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 15),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 50),
                        GrupoDescuentoId = c.Int(nullable: false),
                        CondicionPagoId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteI);
            
            CreateTable(
                "dbo.CondicionPagoes",
                c => new
                    {
                        CondicionPagoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 20),
                        Descripcion = c.String(nullable: false, maxLength: 30),
                        Estado = c.String(),
                        Dias = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CondicionPagoId);
            
            CreateTable(
                "dbo.GrupoDescuentoes",
                c => new
                    {
                        GrupoDescuentoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 20),
                        Descripcion = c.String(nullable: false, maxLength: 150),
                        Estado = c.String(),
                        Porcentaje = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GrupoDescuentoId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        CategoriaId = c.Int(nullable: false),
                        UnidadMedidaId = c.Int(nullable: false),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        Estado = c.String(),
                        PrecioCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId);
            
            CreateTable(
                "dbo.UnidadMedidas",
                c => new
                    {
                        UnidadMedidaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                        Estado = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UnidadMedidaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnidadMedidas");
            DropTable("dbo.Productoes");
            DropTable("dbo.GrupoDescuentoes");
            DropTable("dbo.CondicionPagoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
