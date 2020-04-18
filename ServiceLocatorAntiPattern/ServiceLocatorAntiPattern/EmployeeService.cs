using System.Collections.Generic;

namespace ServiceLocatorAntiPattern
{
    public class EmployeeService
    {
        private IEmployeeRepository _repository;
        public EmployeeService()
        {
            _repository = ServiceLocator.Resolve<EmployeeRepository>();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _repository.GetAll();
        }
    }
}
