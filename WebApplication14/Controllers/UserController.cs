using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeoncdTest.Core.Dto;
using SeoncdTest.Core.Interface;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userservice;

        public UserController(IUserService userService)
        {
            _userservice = userService;

        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody]User user)
        {
            var newUser = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
            var result = await _userservice.AddUser(newUser);

            if (string.IsNullOrEmpty(user.Email)) 
            {

                return BadRequest("Invalid email ");
            }
            return Ok(newUser);
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await _userservice.GetUser();
            return Ok(users);
        }





        [HttpGet("email")]
        public async Task<IActionResult> GetUserEmail()
        {
            var users = await _userservice.GetUserEmail();
            if (!users.Any())
            {
                return NotFound();
            }
            return Ok(users);
        }





        [HttpGet("{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var users = await _userservice.FindByEmail(email );
            if (users == null)
            {
                return NotFound("User Not Found");
            }
            return Ok(users);
        }

    }
}
