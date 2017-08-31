using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fever.Model
{
    public class RoleInfoModel : ModelBase
    {
        [StringLength(50)]
        public string RoleName { get; set; }

        [StringLength(200)]
        public string RoleDescription { get; set; }

        public virtual List<UserInfoModel> UserInfoModelList { get; set; }

        public virtual List<MenuItemInfoModel> MenuItemInfoModelList { get; set; }
        public virtual List<CommandActionInfoModel> CommandActionInfoModelList { get; set; }
    }
}