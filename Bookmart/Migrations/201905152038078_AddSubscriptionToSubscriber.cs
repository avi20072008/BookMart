namespace Bookmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubscriptionToSubscriber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribers", "SubscriptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Subscribers", "SubscriptionId");
            AddForeignKey("dbo.Subscribers", "SubscriptionId", "dbo.Subscriptions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subscribers", "SubscriptionId", "dbo.Subscriptions");
            DropIndex("dbo.Subscribers", new[] { "SubscriptionId" });
            DropColumn("dbo.Subscribers", "SubscriptionId");
        }
    }
}
