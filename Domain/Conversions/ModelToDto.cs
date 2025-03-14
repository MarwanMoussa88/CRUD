using Domain.Models;
using Entities.DTOs;

namespace Entities.Conversions
{
    public static class ModelToDto
    {
        public static EmployeeDto EmployeeToDto(this Employee employee)
        {
            return new EmployeeDto(employee.Id, employee.Name, employee.Age,
                new EmployeeCompanyDto(employee.Company.Id, employee.Company.Name, employee.Company.Address));
        }
    }
}
