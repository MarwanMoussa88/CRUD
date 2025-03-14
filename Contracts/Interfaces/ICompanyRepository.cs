using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Entities.DTOs;

namespace Contracts.Interfaces
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<CompanyDto>> GetCompanies();
        Task<IEnumerable<CompanyDto>> GetCompaniesWithCondition(Expression<Func<Company, bool>> expression,
            bool tracking);
    }
}
