namespace Fever.Compoments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remove_many_foreignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CommandActionInfoModels", "MenuItemId", "dbo.MenuItemInfoModels");
            DropIndex("dbo.CommandActionInfoModels", new[] { "MenuItemId" });
            RenameColumn(table: "dbo.CommandActionInfoModels", name: "MenuItemId", newName: "ParentMenuItem_MenuItemId");
            AlterColumn("dbo.CommandActionInfoModels", "ParentMenuItem_MenuItemId", c => c.Int());
            CreateIndex("dbo.CommandActionInfoModels", "ParentMenuItem_MenuItemId");
            AddForeignKey("dbo.CommandActionInfoModels", "ParentMenuItem_MenuItemId", "dbo.MenuItemInfoModels", "MenuItemId");
            DropColumn("dbo.MenuItemInfoModels", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MenuItemInfoModels", "ParentId", c => c.Int());
            DropForeignKey("dbo.CommandActionInfoModels", "ParentMenuItem_MenuItemId", "dbo.MenuItemInfoModels");
            DropIndex("dbo.CommandActionInfoModels", new[] { "ParentMenuItem_MenuItemId" });
            AlterColumn("dbo.CommandActionInfoModels", "ParentMenuItem_MenuItemId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.CommandActionInfoModels", name: "ParentMenuItem_MenuItemId", newName: "MenuItemId");
            CreateIndex("dbo.CommandActionInfoModels", "MenuItemId");
            AddForeignKey("dbo.CommandActionInfoModels", "MenuItemId", "dbo.MenuItemInfoModels", "MenuItemId", cascadeDelete: true);
        }
    }
}
