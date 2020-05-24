namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "imgUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pets", "imgUrl");
        }
    }
}
