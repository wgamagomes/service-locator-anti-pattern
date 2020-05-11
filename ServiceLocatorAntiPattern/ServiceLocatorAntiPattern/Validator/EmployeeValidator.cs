using ServiceLocatorAntiPattern.Entities;
using ServiceLocatorAntiPattern.Interfaces;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Validator
{
    public class EmployeeValidator : IEmployeeValidator
    {
        public Task<bool> ValidateAsync(Employee employee)
        {
           return Task.Run(() =>
            {
                return !string.IsNullOrEmpty(employee.FirstName)
               && !string.IsNullOrEmpty(employee.LastName);

            });           
        }
    }
}
