using ServiceLocatorAntiPattern.Entities;
using ServiceLocatorAntiPattern.Interfaces;
using ServiceLocatorAntiPattern.Locator;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IEmployeeValidator _validator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailMessageSender _mailMessageSender;

        public EmployeeService()
        {
            _repository = ServiceLocator.Resolve<IEmployeeRepository>();
            _validator = ServiceLocator.Resolve<IEmployeeValidator>();
            _unitOfWork = ServiceLocator.Resolve<IUnitOfWork>();
            _mailMessageSender = ServiceLocator.Resolve<IMailMessageSender>();
        }

        public async Task HandleAsync(Employee employee)
        {
            if (!await _validator.ValidateAsync(employee))
                return;

            await _repository.InsertAsync(employee);

            await _unitOfWork.CommitAsync();

            await _mailMessageSender.Send(employee);
        }
    }

}


