using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fever.Core.Entities
{
    public abstract class EntityBase : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public bool IsSoftDelete { get; set; }
    }
}