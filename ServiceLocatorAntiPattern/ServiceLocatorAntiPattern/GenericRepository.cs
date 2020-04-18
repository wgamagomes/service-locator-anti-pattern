using System.Collections.Generic;

namespace ServiceLocatorAntiPattern
{
    public class  GenericRepository<TEntity>: IGenericRepository<TEntity>

        where TEntity: class, new()
    {
       public IEnumerable<TEntity> GetAll()
        {
            //Some db logic to fetch Entities information 
            return (new List<TEntity>());
        }
    }
}
