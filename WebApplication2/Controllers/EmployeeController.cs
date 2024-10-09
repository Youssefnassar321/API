using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Classes;
using WebApplication2.Model;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeClass employeeClass = new EmployeeClass();

        [HttpPost]
        public IActionResult AddEmployee([FromBody]Employee employee)
        {
            employeeClass.Add(employee);
            if (ModelState.IsValid) 
            {
                return Created("http://localhost:5280/api/employee/"+employee.id,employee);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetData() 
        {
            List<EmployeeDto> emp = employeeClass.list();
            return Ok(emp);
        }

        [HttpPut]
        public IActionResult Update([FromHeader]string id , [FromBody]Employee employee)
        {
             employeeClass.update(ObjectId.Parse(id), employee);
            return StatusCode(StatusCodes.Status204NoContent);
        }

        [HttpDelete]
        public IActionResult Delete([FromHeader]string id) 
        {
            employeeClass.delete(ObjectId.Parse(id));
            return Ok();
        }
    }
}
