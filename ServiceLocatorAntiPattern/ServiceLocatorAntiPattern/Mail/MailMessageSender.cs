using ServiceLocatorAntiPattern.Interfaces;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Mail
{
    public class MailMessageSender : IMailMessageSender
    {
        public Task<bool> Send<TEntity>(TEntity entity)
        {
            return Task.Run(() => true);
        }
    }
}
