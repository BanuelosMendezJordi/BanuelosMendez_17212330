namespace PS1_U3_Eventos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        CityDescription = c.String(),
                        Population = c.String(),
                        Lada = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventDescription = c.String(),
                        Fecha = c.DateTime(),
                        Quota = c.Int(nullable: false),
                        Availability = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "CityId", "dbo.Cities");
            DropIndex("dbo.Events", new[] { "CityId" });
            DropTable("dbo.Events");
            DropTable("dbo.Cities");
        }
    }
}
