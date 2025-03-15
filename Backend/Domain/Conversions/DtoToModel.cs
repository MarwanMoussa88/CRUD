using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Entities.DTOs;

namespace Entities.Conversions
{
    public static class DtoToModel
    {
        public static Employee EmployeeDtoToModel(this EmployeeDto employeeDto)
        {
            return new Employee
            {
                Id = employeeDto.Id,
                Name = employeeDto.Name,
                Age = employeeDto.Age,
                Company = new Company()
                {
                    Id = employeeDto.Company.Id,
                    Name = employeeDto.Company.Name,
                    Address = employeeDto.Company.Address,
                }

            };
        }
        public static Employee CreateEmployeeDtoToModel(this CreateEmployeeDto employeeDto)
        {
            return new Employee
            {
                Id = employeeDto.Id ?? new Guid(),
                Name = employeeDto.Name,
                Age = employeeDto.Age,
                CompanyId = employeeDto.CompanyId
            };
        }

    }
}
