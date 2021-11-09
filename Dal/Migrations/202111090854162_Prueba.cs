namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prueba : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Usuarios", new[] { "Email" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Usuarios", "Email", unique: true);
        }
    }
}
