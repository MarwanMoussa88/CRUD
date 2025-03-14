using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Interfaces;

namespace Presentation.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> Index()
        {
            return Ok(await _companyService.GetCompanies());
        }


    }
}
