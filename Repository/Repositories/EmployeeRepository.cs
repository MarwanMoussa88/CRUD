using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts.HumanCapitalContext;

namespace Repository.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(HumanCapitalContext HumanCapitalContext) : base(HumanCapitalContext)
        {
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await FindAll().Include(c=>c.Company).OrderBy(c => c.Name).ToListAsync();
        }
    }
}
