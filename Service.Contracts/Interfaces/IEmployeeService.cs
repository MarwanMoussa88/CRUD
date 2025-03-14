using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Entities.DTOs;

namespace Service.Contracts
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees();
        Task<EmployeeDto> GetEmployee(Guid id);
        void AddEmployee(CreateEmployeeDto employee);
        void DeleteEmployee(EmployeeDto employee);
        void UpdateEmployee(CreateEmployeeDto employee);
    }
}
