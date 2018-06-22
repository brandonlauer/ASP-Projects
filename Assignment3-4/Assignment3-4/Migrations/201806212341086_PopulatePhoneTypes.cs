namespace Assignment3_4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePhoneTypes : DbMigration
    {
        public override void Up()
        {
            // Android smart phone
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES ('Smart', 'Android')");
            // IOS smart phone
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES ('Smart', 'IOS')");
            // Bar phone
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES ('Bar', 'N/A')");
            // Flip phone
            Sql("INSERT INTO PhoneTypes (Type, OS) VALUES ('Flip', 'N/A')");
        }
        
        public override void Down()
        {
        }
    }
}
