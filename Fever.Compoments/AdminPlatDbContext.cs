using System.Data.Entity;
using Fever.Core.Entities;
using Fever.Model;

namespace Fever.Compoments
{
    public class AdminPlatDbContext : DbContext
    {
        public AdminPlatDbContext()
            : base("AdminPlatConnectionString")
        {
            
        }
        
        public DbSet<UserInfoModel> UserInfoModels { get; set; }
        public DbSet<RoleInfoModel> RoleInfoModels { get; set; }
        public DbSet<MenuItemInfoModel> MenuItemInfoModels { get; set; }
        public DbSet<CommandActionInfoModel> CommandActionInfoModels { get; set; }
    }
}
