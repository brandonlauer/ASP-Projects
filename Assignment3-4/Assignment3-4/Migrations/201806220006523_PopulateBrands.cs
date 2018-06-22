namespace Assignment3_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBrands : DbMigration
    {
        public override void Up()
        {
            //Samsung
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES ('Samsung', 'South Korea')");
            // Apple
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES ('Apple', 'US')");
            // Huawei
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES ('Huawei', 'China')");
            // LG
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES ('LG', 'South Korea')");
            // Nokia
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES ('Nokia', 'Finland')");
            // HTC
            Sql("INSERT INTO Brands (BrandName, CountryOfOrigin) VALUES ('HTC', 'Taiwan')");
        }
        
        public override void Down()
        {
        }
    }
}
