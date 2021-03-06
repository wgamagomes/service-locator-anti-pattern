﻿using ServiceLocatorAntiPattern.Entities;
using System.Threading.Tasks;

namespace ServiceLocatorAntiPattern.Interfaces
{
    public interface IEmployeeValidator
    {
        Task<bool> ValidateAsync(Employee employee);
    }
}
