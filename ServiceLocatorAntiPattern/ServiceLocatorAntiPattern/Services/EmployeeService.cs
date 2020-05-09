using ServiceLocatorAntiPattern.Entities;
using ServiceLocatorAntiPattern.Interfaces;
using ServiceLocatorAntiPattern.Repositories;
using ServiceLocatorAntiPattern.Validator;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IEmployeeValidator _validator;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService()
        {
            _repository = ServiceLocator.Resolve<EmployeeRepository>();
            _validator = ServiceLocator.Resolve<EmployeeValidator>();
            _unitOfWork = ServiceLocator.Resolve<UnitOfWork>();
        }

        public async Task HandleAsync(Employee employee)
        {
            if (!await _validator.ValidateAsync(employee))
                return;

            await _repository.InsertAsync(employee);

            await _unitOfWork.CommitAsync();
        }
    }
}
