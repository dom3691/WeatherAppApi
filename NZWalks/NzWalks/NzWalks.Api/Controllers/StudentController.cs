using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NzWalks.Api.Controllers
{
    //https
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {

            string[] studentNames = new string[] { "John", "Dominic", "Owoicho" };
            return Ok(studentNames); 
        }
    }
}
