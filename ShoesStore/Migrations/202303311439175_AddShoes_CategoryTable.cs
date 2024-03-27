namespace ShoesStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShoes_CategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Hang = c.String(maxLength: 500),
                        Image = c.String(maxLength: 250),
                        CateId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Shoes");
            DropTable("dbo.Category");
        }
    }
}
