namespace ShoesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPhone_NameColumnToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Name");
            DropColumn("dbo.AspNetUsers", "Phone");
        }
    }
}
