using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostCandidate.Models;
using PostCandidateCore.Dto;
using PostCandidateCore.Interfaces;

namespace PostCandidate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private ICandidateService _userservice;

        public CandidateController(ICandidateService userService)
        {
            _userservice = userService;

        }


        [HttpPost]
        public async Task <IActionResult> AddUser([FromBody]CandidateDto user)
        {
            var newUser = new CandidateDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,

            };
            var result = await _userservice.AddUser(newUser);

            if (String.IsNullOrEmpty (user.Email))
            {
                return BadRequest("Invalid Email");
            }
            return Ok(newUser);
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await _userservice.GetUser();
            return Ok(users);
        }
    }
}
