using AddCandidate.Core.Dto;
using AddCandidate.Core.Interface;
using AddCandidate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddCandidate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _repository;

        public UserController (IUserService repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<UserDto> CreateCandidateProfile([FromForm] UserDto profile)
        {
            _repository.Add(profile);
            //  _repository.SaveChanges();

            return CreatedAtAction(nameof(GetCandidateProfile), new { id = profile.Id }, profile);
        }

        [HttpGet("{id}")]
        public ActionResult<UserDto> GetCandidateProfile(int id)
        {
            var profile = _repository.GetById(id);

            if (profile == null)
            {
                return NotFound();
            }

            return profile;
        }
    }
}
