using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Interfaces
{
    public interface IMailMessageSender
    {
        Task<bool> Send<TEntity>(TEntity entity);
    }
}
