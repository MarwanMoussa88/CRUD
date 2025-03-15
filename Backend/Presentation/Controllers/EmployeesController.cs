using Domain.Models;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Service.Contracts.Interfaces;

namespace Presentation.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> Index()
        {
            return Ok(await _employeeService.GetEmployees());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployeeById(Guid id)
        {
            EmployeeDto employee = await _employeeService.GetEmployee(id);
            return employee == null ? NotFound(employee) : Ok(employee);
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromBody] CreateEmployeeDto employee)
        {
            _employeeService.UpdateEmployee(employee);
            return NoContent();

        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] CreateEmployeeDto employee)
        {
            _employeeService.AddEmployee(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            _employeeService.DeleteEmployee(id);
            return NoContent();
        }


    }
}
