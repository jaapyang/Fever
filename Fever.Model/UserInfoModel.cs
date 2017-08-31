using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fever.Model
{
    public class UserInfoModel
    {
        [Key]
        [StringLength(30)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserState UserState { get; set; }

        public virtual List<RoleInfoModel> RoleInfoModelList { get; set; }
    }
}