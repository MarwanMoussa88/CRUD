using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Service.Contracts.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetCompanies();

    }
}
