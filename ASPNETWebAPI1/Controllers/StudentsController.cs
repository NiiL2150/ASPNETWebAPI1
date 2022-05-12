using ASPNETWebAPI1.Interfaces;
using ASPNETWebAPI1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETWebAPI1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _students;

        public StudentsController(IStudentsService students)
        {
            this._students = students;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this._students.GetAllStudents());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._students.GetStudent(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student result)
        {
            return Ok(await this._students.AddStudent(result));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Student result)
        {
            return Ok(await this._students.EditStudent(result));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await this._students.DeleteStudent(id));
        }
    }
}
