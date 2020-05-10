using ServiceLocatorAntiPattern.Interfaces;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task<bool> CommitAsync()
        {
            return Task.Run(() => true);
        }
    }
}
