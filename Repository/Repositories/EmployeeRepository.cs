using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Domain.Models;
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

        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            return await FindAll().OrderBy(c => c.Name).Include(c => c.Company)
                .Select(c =>
                new EmployeeDto(c.Id, c.Name, c.Age,
                new EmployeeCompanyDto(c.Company.Id, c.Company.Name, c.Company.Address)))
                .ToListAsync();
        }
    }
}
