using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public record CompanyDto(Guid Id,string Name,string Address,IEnumerable<CompanyEmployeeDto> employees);

}
