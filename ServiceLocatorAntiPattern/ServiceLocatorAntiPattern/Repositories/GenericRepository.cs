using ServiceLocatorAntiPattern.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Repositories
{
    public class  GenericRepository<TEntity>: IGenericRepository<TEntity>

        where TEntity: class, new()
    {
        private List<TEntity> _entities;
        public GenericRepository()
        {
            _entities = new List<TEntity>();
        }
       public IEnumerable<TEntity> GetAll()
        {
            //Some db logic to fetch Entities information 
            return _entities;
        }

        public async Task InsertAsync(TEntity entity)
        {
           await  Task.Run(() => {
                _entities.Add(entity);
            });           
        }
    }
}
