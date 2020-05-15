using ServiceLocatorAntiPattern.Entities;
using ServiceLocatorAntiPattern.Services;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Bootstrapper.Register();

            var employeeService = new EmployeeService();

            var employee = new Employee { FirstName = "Wellington", LastName = "Gomes" };

            await employeeService.HandleAsync(employee); 
        }
    }
}









