namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cntts",
                c => new
                    {
                        idsv = c.String(nullable: false, maxLength: 128),
                        pascal = c.Single(nullable: false),
                        csap = c.Single(nullable: false),
                        sql = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.idsv);
            
            CreateTable(
                "dbo.vans",
                c => new
                    {
                        idsv = c.String(nullable: false, maxLength: 128),
                        vhcd = c.Single(nullable: false),
                        vhhh = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.idsv);
            
            CreateTable(
                "dbo.vatlies",
                c => new
                    {
                        idsv = c.String(nullable: false, maxLength: 128),
                        cohoc = c.Single(nullable: false),
                        quanhoc = c.Single(nullable: false),
                        dien = c.Single(nullable: false),
                        vlhatnhan = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.idsv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.vatlies");
            DropTable("dbo.vans");
            DropTable("dbo.cntts");
        }
    }
}
