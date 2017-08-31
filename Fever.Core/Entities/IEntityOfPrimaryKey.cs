using System;
using System.ComponentModel.DataAnnotations;

namespace Fever.Core.Entities
{
    public interface IEntity : IEntity<int>
    {
    }

    public interface IEntity<TPrimaryKey> :ICreateTime, IUpdateTime, IIsSoftDelete,ICreateBy,IUpdateBy
    {
        [Key]
        TPrimaryKey Id { get; set; }
    }

    public abstract class EntityBase : IEntity
    {
        public DateTime CreateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public bool IsSoftDelete { get; set; }
        public int Id { get; set; }
    }
}