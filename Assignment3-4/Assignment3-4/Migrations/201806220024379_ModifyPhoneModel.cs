namespace Assignment3_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPhoneModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Phones", "Brand_ID", "dbo.Brands");
            DropForeignKey("dbo.Phones", "PhoneType_ID", "dbo.PhoneTypes");
            DropIndex("dbo.Phones", new[] { "Brand_ID" });
            DropIndex("dbo.Phones", new[] { "PhoneType_ID" });
            RenameColumn(table: "dbo.Phones", name: "Brand_ID", newName: "BrandID");
            RenameColumn(table: "dbo.Phones", name: "PhoneType_ID", newName: "PhoneTypeID");
            AlterColumn("dbo.Phones", "BrandID", c => c.Int(nullable: false));
            AlterColumn("dbo.Phones", "PhoneTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Phones", "BrandID");
            CreateIndex("dbo.Phones", "PhoneTypeID");
            AddForeignKey("dbo.Phones", "BrandID", "dbo.Brands", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Phones", "PhoneTypeID", "dbo.PhoneTypes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "PhoneTypeID", "dbo.PhoneTypes");
            DropForeignKey("dbo.Phones", "BrandID", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "PhoneTypeID" });
            DropIndex("dbo.Phones", new[] { "BrandID" });
            AlterColumn("dbo.Phones", "PhoneTypeID", c => c.Int());
            AlterColumn("dbo.Phones", "BrandID", c => c.Int());
            RenameColumn(table: "dbo.Phones", name: "PhoneTypeID", newName: "PhoneType_ID");
            RenameColumn(table: "dbo.Phones", name: "BrandID", newName: "Brand_ID");
            CreateIndex("dbo.Phones", "PhoneType_ID");
            CreateIndex("dbo.Phones", "Brand_ID");
            AddForeignKey("dbo.Phones", "PhoneType_ID", "dbo.PhoneTypes", "ID");
            AddForeignKey("dbo.Phones", "Brand_ID", "dbo.Brands", "ID");
        }
    }
}
