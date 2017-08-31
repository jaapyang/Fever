using System.Linq;
using Fever.Core.Entities;

namespace Fever.Core.DomainService
{
    public class DomainServiceBase : IDomainService
    {
        public IQueryable<TEntity> GetRepository<TEntity>() where TEntity : IEntity
        {
            throw new System.NotImplementedException();
        }
    }
}