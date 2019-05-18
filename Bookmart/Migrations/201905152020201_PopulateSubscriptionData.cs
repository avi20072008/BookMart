namespace Bookmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSubscriptionData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Subscriptions ON");
            Sql("INSERT INTO Subscriptions (Id, SubscriptionType, Discount) VALUES (1, 'Monthly', 10)");
            Sql("INSERT INTO Subscriptions (Id, SubscriptionType, Discount) VALUES (2, 'Annual', 30)");
        }

        public override void Down()
        {
        }
    }
}
