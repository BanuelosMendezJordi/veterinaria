namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOwner : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pets", "Owner_id", "dbo.Owners");
            DropIndex("dbo.Pets", new[] { "Owner_id" });
            RenameColumn(table: "dbo.Pets", name: "Owner_id", newName: "OwnerId");
            RenameColumn(table: "dbo.Owners", name: "ApplicationUser_Id", newName: "UserId");
            RenameIndex(table: "dbo.Owners", name: "IX_ApplicationUser_Id", newName: "IX_UserId");
            AlterColumn("dbo.Pets", "OwnerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pets", "OwnerId");
            AddForeignKey("dbo.Pets", "OwnerId", "dbo.Owners", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "OwnerId", "dbo.Owners");
            DropIndex("dbo.Pets", new[] { "OwnerId" });
            AlterColumn("dbo.Pets", "OwnerId", c => c.Int());
            RenameIndex(table: "dbo.Owners", name: "IX_UserId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Owners", name: "UserId", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.Pets", name: "OwnerId", newName: "Owner_id");
            CreateIndex("dbo.Pets", "Owner_id");
            AddForeignKey("dbo.Pets", "Owner_id", "dbo.Owners", "id");
        }
    }
}
