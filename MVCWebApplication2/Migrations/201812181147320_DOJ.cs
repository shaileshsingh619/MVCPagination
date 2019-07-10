namespace MVCWebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOJ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DOJ", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DOJ");
        }
    }
}
