using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocatorAntiPattern
{
    public interface  IGenericRepository<TEntity> where TEntity: class, new()
    {
        IEnumerable<TEntity> GetAll();
    }
}
