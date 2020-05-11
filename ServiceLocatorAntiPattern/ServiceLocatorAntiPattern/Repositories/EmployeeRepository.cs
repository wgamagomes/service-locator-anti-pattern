using ServiceLocatorAntiPattern.Entities;
using ServiceLocatorAntiPattern.Interfaces;

namespace ServiceLocatorAntiPattern.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {
       
    }
}
