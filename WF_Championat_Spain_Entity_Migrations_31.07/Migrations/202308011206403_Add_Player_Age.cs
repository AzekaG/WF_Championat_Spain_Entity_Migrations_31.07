namespace WF_Championat_Spain_Entity_Migrations_31._07.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Player_Age : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Age");
        }
    }
}
