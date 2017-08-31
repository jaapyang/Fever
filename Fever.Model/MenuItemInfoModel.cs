using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fever.Model
{
    public class MenuItemInfoModel : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuItemId { get; set; }
        [StringLength(20)]
        public string MenuItemText { get; set; }
        [StringLength(50)]
        public string ActionName { get; set; }
        [StringLength(50)]
        public string ControllerName { get; set; }

        public virtual MenuItemInfoModel ParentMenuItem { get; set; }
        public virtual List<RoleInfoModel> RoleInfoModelList { get; set; }
        public virtual List<CommandActionInfoModel> CommandActionInfoModelList { get; set; }
        public virtual List<MenuItemInfoModel> ChildMenuItems { get; set; }
    }
}