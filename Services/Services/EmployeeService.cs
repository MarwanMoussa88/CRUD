using Contracts.Interfaces;
using Domain.Models;
using Entities.DTOs;
using Service.Contracts;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void AddEmployee(CreateEmployeeDto employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public void DeleteEmployee(EmployeeDto employee)
        {
            _employeeRepository.DeleteEmployee(employee);
        }

        public async Task<EmployeeDto> GetEmployee(Guid id)
        {
            return await _employeeRepository.GetEmployee(id);
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }

        public void UpdateEmployee(CreateEmployeeDto employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

    }
}
