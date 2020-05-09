using System.Collections.Generic;

namespace ServiceLocatorAntiPattern.Interfaces
{
    public interface  IGenericRepository<TEntity> where TEntity: class, new()
    {
        IEnumerable<TEntity> GetAll();
    }
}
