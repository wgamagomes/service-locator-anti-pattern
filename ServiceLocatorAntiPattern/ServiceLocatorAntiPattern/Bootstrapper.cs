using ServiceLocatorAntiPattern.Interfaces;
using ServiceLocatorAntiPattern.Locator;
using ServiceLocatorAntiPattern.Repositories;
using ServiceLocatorAntiPattern.Validator;

namespace ServiceLocatorAntiPattern
{
    public class Bootstrapper
    {
        public static void Register()
        {
            ServiceLocator.Register<IEmployeeValidator, EmployeeValidator>(() => new EmployeeValidator());
            ServiceLocator.Register<IEmployeeRepository, EmployeeRepository>(() => new EmployeeRepository());
            ServiceLocator.Register<IUnitOfWork, UnitOfWork>(() => new UnitOfWork());

        }
    }
}


