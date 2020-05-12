using ServiceLocatorAntiPattern.Entities;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Interfaces
{
    public interface IEmployeeService
    {
        Task HandleAsync(Employee employee);
    }
}
