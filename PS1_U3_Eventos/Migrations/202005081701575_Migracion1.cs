namespace PS1_U3_Eventos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Population", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "Population", c => c.String());
        }
    }
}
