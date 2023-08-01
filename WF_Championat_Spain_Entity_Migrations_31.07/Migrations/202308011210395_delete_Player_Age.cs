namespace WF_Championat_Spain_Entity_Migrations_31._07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete_Player_Age : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Age", c => c.Int(nullable: false));
        }
    }
}
