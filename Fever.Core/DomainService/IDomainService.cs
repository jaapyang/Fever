using System.Linq;
using Fever.Core.Entities;

namespace Fever.Core.DomainService
{
    public interface IDomainService
    {
        IQueryable<TEntity> GetRepository<TEntity>() 
            where TEntity : IEntity;
    }
}
