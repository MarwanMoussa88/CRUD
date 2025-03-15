﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Entities.DTOs;

namespace Contracts.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees();
        Task<EmployeeDto> GetEmployee(Guid id);
        void AddEmployee(CreateEmployeeDto employee);
        Task DeleteEmployee(Guid id);
        void UpdateEmployee(CreateEmployeeDto employee);
    }
}
