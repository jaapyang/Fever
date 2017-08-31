using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fever.Model
{
    public class CommandActionInfoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommandActionId { get; set; }

        [StringLength(50)]
        public string ActionName { get; set; }

        [StringLength(50)]
        public string ControllerName { get; set; }

        [StringLength(50)]
        public string CommandText { get; set; }

        public virtual MenuItemInfoModel ParentMenuItem { get; set; }
        public virtual List<RoleInfoModel> RoleInfoModelList { get; set; }
    }
}