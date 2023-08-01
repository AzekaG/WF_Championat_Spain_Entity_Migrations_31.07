namespace WF_Championat_Spain_Entity_Migrations_31._07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Number = c.Int(nullable: false),
                        Country_Id = c.Int(),
                        Position_Id = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Position_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Match_Id = c.Int(),
                        Player_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.Match_Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .Index(t => t.Match_Id)
                .Index(t => t.Player_Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        FirstTeam_Id = c.Int(),
                        SecondTeam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.FirstTeam_Id)
                .ForeignKey("dbo.Teams", t => t.SecondTeam_Id)
                .Index(t => t.FirstTeam_Id)
                .Index(t => t.SecondTeam_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Matches", "SecondTeam_Id", "dbo.Teams");
            DropForeignKey("dbo.Goals", "Match_Id", "dbo.Matches");
            DropForeignKey("dbo.Matches", "FirstTeam_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Players", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Matches", new[] { "SecondTeam_Id" });
            DropIndex("dbo.Matches", new[] { "FirstTeam_Id" });
            DropIndex("dbo.Goals", new[] { "Player_Id" });
            DropIndex("dbo.Goals", new[] { "Match_Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Players", new[] { "Position_Id" });
            DropIndex("dbo.Players", new[] { "Country_Id" });
            DropTable("dbo.Matches");
            DropTable("dbo.Goals");
            DropTable("dbo.Teams");
            DropTable("dbo.Positions");
            DropTable("dbo.Players");
            DropTable("dbo.Countries");
        }
    }
}
