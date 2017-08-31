using System;

namespace Fever.Core.Entities
{
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