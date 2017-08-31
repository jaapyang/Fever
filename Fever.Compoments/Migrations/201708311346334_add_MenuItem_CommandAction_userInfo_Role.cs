namespace Fever.Compoments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_MenuItem_CommandAction_userInfo_Role : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommandActionInfoModels",
                c => new
                    {
                        CommandActionId = c.Int(nullable: false, identity: true),
                        ActionName = c.String(maxLength: 50),
                        ControllerName = c.String(maxLength: 50),
                        CommandText = c.String(maxLength: 50),
                        MenuItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommandActionId)
                .ForeignKey("dbo.MenuItemInfoModels", t => t.MenuItemId, cascadeDelete: true)
                .Index(t => t.MenuItemId);
            
            CreateTable(
                "dbo.MenuItemInfoModels",
                c => new
                    {
                        MenuItemId = c.Int(nullable: false, identity: true),
                        MenuItemText = c.String(maxLength: 20),
                        ActionName = c.String(maxLength: 50),
                        ControllerName = c.String(maxLength: 50),
                        ParentId = c.Int(),
                        ParentMenuItem_MenuItemId = c.Int(),
                    })
                .PrimaryKey(t => t.MenuItemId)
                .ForeignKey("dbo.MenuItemInfoModels", t => t.ParentMenuItem_MenuItemId)
                .Index(t => t.ParentMenuItem_MenuItemId);
            
            CreateTable(
                "dbo.RoleInfoModels",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 50),
                        RoleDescription = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.UserInfoModels",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 30),
                        Password = c.String(),
                        UserState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.RoleInfoModelCommandActionInfoModels",
                c => new
                    {
                        RoleInfoModel_RoleId = c.Int(nullable: false),
                        CommandActionInfoModel_CommandActionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleInfoModel_RoleId, t.CommandActionInfoModel_CommandActionId })
                .ForeignKey("dbo.RoleInfoModels", t => t.RoleInfoModel_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.CommandActionInfoModels", t => t.CommandActionInfoModel_CommandActionId, cascadeDelete: true)
                .Index(t => t.RoleInfoModel_RoleId)
                .Index(t => t.CommandActionInfoModel_CommandActionId);
            
            CreateTable(
                "dbo.RoleInfoModelMenuItemInfoModels",
                c => new
                    {
                        RoleInfoModel_RoleId = c.Int(nullable: false),
                        MenuItemInfoModel_MenuItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleInfoModel_RoleId, t.MenuItemInfoModel_MenuItemId })
                .ForeignKey("dbo.RoleInfoModels", t => t.RoleInfoModel_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.MenuItemInfoModels", t => t.MenuItemInfoModel_MenuItemId, cascadeDelete: true)
                .Index(t => t.RoleInfoModel_RoleId)
                .Index(t => t.MenuItemInfoModel_MenuItemId);
            
            CreateTable(
                "dbo.UserInfoModelRoleInfoModels",
                c => new
                    {
                        UserInfoModel_UserName = c.String(nullable: false, maxLength: 30),
                        RoleInfoModel_RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserInfoModel_UserName, t.RoleInfoModel_RoleId })
                .ForeignKey("dbo.UserInfoModels", t => t.UserInfoModel_UserName, cascadeDelete: true)
                .ForeignKey("dbo.RoleInfoModels", t => t.RoleInfoModel_RoleId, cascadeDelete: true)
                .Index(t => t.UserInfoModel_UserName)
                .Index(t => t.RoleInfoModel_RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoModelRoleInfoModels", "RoleInfoModel_RoleId", "dbo.RoleInfoModels");
            DropForeignKey("dbo.UserInfoModelRoleInfoModels", "UserInfoModel_UserName", "dbo.UserInfoModels");
            DropForeignKey("dbo.RoleInfoModelMenuItemInfoModels", "MenuItemInfoModel_MenuItemId", "dbo.MenuItemInfoModels");
            DropForeignKey("dbo.RoleInfoModelMenuItemInfoModels", "RoleInfoModel_RoleId", "dbo.RoleInfoModels");
            DropForeignKey("dbo.RoleInfoModelCommandActionInfoModels", "CommandActionInfoModel_CommandActionId", "dbo.CommandActionInfoModels");
            DropForeignKey("dbo.RoleInfoModelCommandActionInfoModels", "RoleInfoModel_RoleId", "dbo.RoleInfoModels");
            DropForeignKey("dbo.CommandActionInfoModels", "MenuItemId", "dbo.MenuItemInfoModels");
            DropForeignKey("dbo.MenuItemInfoModels", "ParentMenuItem_MenuItemId", "dbo.MenuItemInfoModels");
            DropIndex("dbo.UserInfoModelRoleInfoModels", new[] { "RoleInfoModel_RoleId" });
            DropIndex("dbo.UserInfoModelRoleInfoModels", new[] { "UserInfoModel_UserName" });
            DropIndex("dbo.RoleInfoModelMenuItemInfoModels", new[] { "MenuItemInfoModel_MenuItemId" });
            DropIndex("dbo.RoleInfoModelMenuItemInfoModels", new[] { "RoleInfoModel_RoleId" });
            DropIndex("dbo.RoleInfoModelCommandActionInfoModels", new[] { "CommandActionInfoModel_CommandActionId" });
            DropIndex("dbo.RoleInfoModelCommandActionInfoModels", new[] { "RoleInfoModel_RoleId" });
            DropIndex("dbo.MenuItemInfoModels", new[] { "ParentMenuItem_MenuItemId" });
            DropIndex("dbo.CommandActionInfoModels", new[] { "MenuItemId" });
            DropTable("dbo.UserInfoModelRoleInfoModels");
            DropTable("dbo.RoleInfoModelMenuItemInfoModels");
            DropTable("dbo.RoleInfoModelCommandActionInfoModels");
            DropTable("dbo.UserInfoModels");
            DropTable("dbo.RoleInfoModels");
            DropTable("dbo.MenuItemInfoModels");
            DropTable("dbo.CommandActionInfoModels");
        }
    }
}
