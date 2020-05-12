using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Interfaces
{
    public interface  IGenericRepository<TEntity> where TEntity: class, new()
    {
        IEnumerable<TEntity> GetAll();

        Task InsertAsync(TEntity entity);
    }
}
