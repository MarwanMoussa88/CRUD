﻿using Domain.Models;
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
        public async Task<ActionResult<IEnumerable<Employee>>> Index()
        {
            return Ok(await _employeeService.GetEmployees());
        }


    }
}
