using System.ComponentModel.DataAnnotations;

namespace Fever.Core.Entities
{
    public interface IEntity<TPrimaryKey> :ICreateTime, IUpdateTime, IIsSoftDelete,ICreateBy,IUpdateBy
    {
        [Key]
        TPrimaryKey Id { get; set; }
    }
}