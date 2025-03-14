using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Domain.Models;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts.HumanCapitalContext;

namespace Repository.Repositories
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(HumanCapitalContext HumanCapitalContext) : base(HumanCapitalContext)
        {
        }

        public async Task<IEnumerable<CompanyDto>> GetCompanies()
        {
            return await FindAll().OrderBy(c => c.Name)
                .Include(c => c.Employees)
                .Select(c => new CompanyDto
                (
                    c.Id,
                    c.Name,
                    c.Address,
                    c.Employees.Select(c => new CompanyEmployeeDto(c.Id, c.Name, c.Age))
                )).ToListAsync();
        }

        public async Task<IEnumerable<CompanyDto>> GetCompaniesWithCondition(Expression<Func<Company, bool>> expression,
            bool tracking)
        {
            return await FindAllByCondition(expression, tracking).OrderBy(c => c.Name)
                .Select(c => new CompanyDto
                (
                    c.Id,
                    c.Name,
                    c.Address,
                    c.Employees.Select(c => new CompanyEmployeeDto(c.Id, c.Name, c.Age))
                )).ToListAsync();
        }

    }
}
