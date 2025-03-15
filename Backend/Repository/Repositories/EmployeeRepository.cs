using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Domain.Models;
using Entities.Conversions;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts.HumanCapitalContext;

namespace Repository.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(HumanCapitalContext HumanCapitalContext) : base(HumanCapitalContext)
        {
        }

        public void AddEmployee(CreateEmployeeDto employee)
        {
            var addedEmployee = employee.CreateEmployeeDtoToModel();
            addedEmployee.Id = Guid.NewGuid();
            Create(addedEmployee);
            SaveChanges();
        }

        public async Task DeleteEmployee(Guid id)
        {
            Employee employee = await FindById(id);
            if (employee == null) return;
            Delete(employee);
            SaveChanges();
        }

        public async Task<EmployeeDto> GetEmployee(Guid id)
        {
            var employee = await FindAllByCondition(c => c.Id == id, false).Include(c => c.Company)
                .FirstOrDefaultAsync();
            return employee.EmployeeToDto();
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            return await FindAll().OrderBy(c => c.Name).Include(c => c.Company)
                .Select(c => c.EmployeeToDto())
                .ToListAsync();
        }

        public void UpdateEmployee(CreateEmployeeDto employee)
        {
            Update(employee.CreateEmployeeDtoToModel());
            SaveChanges();
        }
    }
}
