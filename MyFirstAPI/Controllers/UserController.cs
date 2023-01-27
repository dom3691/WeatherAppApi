using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MyFirstAPI.Models;
using UserTest.Dto;
using UserTest.Interface;

namespace MyFirstAPI.Controllers
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
        public async Task<IActionResult> AddUser([FromBody] UserDto user)
        {
            var newUser = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
            var result = await _userservice.AddUser(user);
            return Ok(newUser);
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await _userservice.GetUser();
           
            return Ok(users);
        }
       
        [HttpGet("{email}")]
        public async Task<IActionResult> GetUserByEmail (string email)
        {
            var users = await _userservice.FindByEmail(email);

            if (User == null)
            {
                return NotFound("User Not Found");
            }

            return Ok(users);
        }

    }
}
