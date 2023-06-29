using Candidate.Core.Dto;
using Candidate.Core.Interfaces;
using Candidate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Candidate.Controllers
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
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var newUser = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                //MiddleName = user.MiddleName,
                //Username = user.Username,
                //DateOfBirth = user.DateOfBirth,
                //Gender = user.Gender,
                //Address = user.Address,
                //City = user.City,
                //ZipCode= user.ZipCode,
                //State= user.State,
                //Language= user.Language,

            };
            var result = await _userservice.AddUser(newUser);

            if (result !=null)
            {
                return Ok (user);
            }
          return BadRequest("User Cannot be added");

        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await _userservice.GetUser();
               
            return Ok(users);
        }
    }
}
