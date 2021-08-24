namespace BMBTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Orders", new[] { "Restaurant_Id" });
            AddColumn("dbo.Customers", "ConfirmPassword", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Orders", "Name", c => c.String());
            AddColumn("dbo.Employees", "ConfirmPassword", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "Restaurant_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.FoodItems", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
            CreateIndex("dbo.Orders", "Restaurant_Id");
            AddForeignKey("dbo.Orders", "Restaurant_Id", "dbo.Restaurants", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Orders", new[] { "Restaurant_Id" });
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "Password", c => c.String());
            AlterColumn("dbo.Employees", "UserName", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Restaurants", "Name", c => c.String());
            AlterColumn("dbo.FoodItems", "Name", c => c.String());
            AlterColumn("dbo.Orders", "Restaurant_Id", c => c.Int());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Password", c => c.String());
            AlterColumn("dbo.Customers", "UserName", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Employees", "ConfirmPassword");
            DropColumn("dbo.Orders", "Name");
            DropColumn("dbo.Customers", "ConfirmPassword");
            CreateIndex("dbo.Orders", "Restaurant_Id");
            AddForeignKey("dbo.Orders", "Restaurant_Id", "dbo.Restaurants", "Id");
        }
    }
}
