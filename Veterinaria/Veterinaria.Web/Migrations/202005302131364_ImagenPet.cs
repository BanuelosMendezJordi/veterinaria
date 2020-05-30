namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagenPet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "PetImage", c => c.String());
            DropColumn("dbo.Pets", "PetImg");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "PetImg", c => c.Binary());
            DropColumn("dbo.Pets", "PetImage");
        }
    }
}
