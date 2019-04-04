namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
