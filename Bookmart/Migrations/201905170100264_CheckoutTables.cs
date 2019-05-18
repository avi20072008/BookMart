namespace Bookmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckoutTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checkouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCheckout = c.DateTime(nullable: false),
                        DateCheckIn = c.DateTime(),
                        Book_Id = c.Int(nullable: false),
                        Subscriber_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.Subscribers", t => t.Subscriber_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.Subscriber_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Checkouts", "Subscriber_Id", "dbo.Subscribers");
            DropForeignKey("dbo.Checkouts", "Book_Id", "dbo.Books");
            DropIndex("dbo.Checkouts", new[] { "Subscriber_Id" });
            DropIndex("dbo.Checkouts", new[] { "Book_Id" });
            DropTable("dbo.Checkouts");
        }
    }
}
