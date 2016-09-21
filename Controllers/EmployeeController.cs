using System;
using EmployeeCvManager.Helpers;
using EmployeeCvManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace EmployeeCvManager.Controllers
{
    [Authorize]
    [Route("api/employee")]
    public class EmployeeController : Controller
    {
        private readonly IMemoryCache _memoryCache;

        public EmployeeController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = EmployeeHelper.GetEmployees(_memoryCache);

            if (employees != null)
            {
                return Ok(employees);
            }
            else
            {
                return NoContent();
            }
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var employee = EmployeeHelper.GetEmployee(_memoryCache, id);

            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return BadRequest(new { Error = "Could not find employee." });
            }
        }
        
        [HttpPost]
        public IActionResult Post([FromBody]EmployeeModel model)
        {
            if (EmployeeHelper.CreateEmployee(_memoryCache, model))
            {
                return Created("/api/employee", model);
            }
            else
            {
                return BadRequest(new { Error = "Could not create employee." });
            }
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]EmployeeModel model)
        {
            if (EmployeeHelper.UpdateEmployee(_memoryCache, id, model))
            {
                return Ok();
            }
            else
            {
                return BadRequest(new { Error = "Could not update employee." });
            }
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (EmployeeHelper.DeleteEmployee(_memoryCache, id))
            {
                return Ok();
            }
            else
            {
                return BadRequest(new { Error = "Could not delete employee." });
            }
        }
    }
}