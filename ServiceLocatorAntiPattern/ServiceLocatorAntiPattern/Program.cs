using ServiceLocatorAntiPattern.Entities;
using ServiceLocatorAntiPattern.Interfaces;
using ServiceLocatorAntiPattern.Repositories;
using ServiceLocatorAntiPattern.Services;
using ServiceLocatorAntiPattern.Validator;
using System;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Bootstrapper.Register();

            var employeeService = new EmployeeService();

            await employeeService.HandleAsync(new Employee { FirstName = "Ton", LastName = "Gomes" });
        }
    }
}
