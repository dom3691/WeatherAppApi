using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication11.Model;

namespace WebApplication11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody]User user)
            )    
    }
}
