namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "SupplierCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String());
            AlterColumn("dbo.Suppliers", "Email", c => c.String());
            AlterColumn("dbo.Suppliers", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Phone", c => c.String(maxLength: 50));
            AlterColumn("dbo.Suppliers", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Suppliers", "SupplierCode", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
