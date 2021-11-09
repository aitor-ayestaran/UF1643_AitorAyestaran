namespace Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Descuento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "Descuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productos", "Descuento");
        }
    }
}
