namespace ShoesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterBookTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shoes", "CateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Shoes", "CateId");
            AddForeignKey("dbo.Shoes", "CateId", "dbo.Category", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shoes", "CateId", "dbo.Category");
            DropIndex("dbo.Shoes", new[] { "CateId" });
            AlterColumn("dbo.Shoes", "CateId", c => c.Int());
        }
    }
}
