using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts.HumanCapitalContext;

namespace Repository.Repositories
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(HumanCapitalContext HumanCapitalContext) : base(HumanCapitalContext)
        {
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            return await FindAll().Include(c => c.Employees).OrderBy(c => c.Name).ToListAsync();
        }

        public async Task<IEnumerable<Company>> GetCompaniesWithCondition(Expression<Func<Company, bool>> expression,
            bool tracking)
        {
            return await FindAllByCondition(expression, tracking).OrderBy(c => c.Name).ToListAsync();
        }

    }
}
