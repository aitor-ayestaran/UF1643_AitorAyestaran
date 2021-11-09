namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Foto = c.String(maxLength: 50),
                        Unidad = c.String(nullable: false),
                        PrecioUnidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 64),
                        Nombre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuarios", new[] { "Email" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Productos");
        }
    }
}
