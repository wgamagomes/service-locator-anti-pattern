using ServiceLocatorAntiPattern.Interfaces;

namespace ServiceLocatorAntiPattern.Validator
{
    public class EmployeeValidator : IEmployeeValidator
    {
        public bool Validate(Employee employee)
        {
            return !string.IsNullOrEmpty(employee.FirstName)
                && !string.IsNullOrEmpty(employee.LastName);
        }
    }
}
