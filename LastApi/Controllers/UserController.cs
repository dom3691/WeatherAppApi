using LastApi.Models;
using LastAPICore.Dto;
using LastAPICore.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LastApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost]
        public async Task <IActionResult> AddUser ([FromBody] User user)
        {
            var newUser = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
            };

            var result = await _userService.AddUser(newUser);


            if (string.IsNullOrEmpty (user.Email))
            {
                return BadRequest("Email Is Invalid");
            }

            return Ok(newUser);
        }

        [HttpGet]
        public async Task<IActionResult> GetUser ()
        {
            var users = await _userService.GetUser();
           

            return Ok(users);
        }




    }
}
