using FinalAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Testing.Core.DTO;
using Testing.Core.Interface;

namespace FinalAPI.Controllers
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
        public async Task<IActionResult> AddUser ([FromBody]User user)
        {
            var newUser = new UserDto()
                         
            { 
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
            };
            var result = await _userService.AddUser(newUser);
            if (string.IsNullOrEmpty(result.Email))
            {
                return NotFound("User Not FOund");
            }
            return Ok(result);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
           
            var users   = await _userService.GetUser();
            return Ok(users);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllTransaction()
        //{

        //    var users = await _userService.GetUser();
        //    return Ok(users);
        //}
    }

}
