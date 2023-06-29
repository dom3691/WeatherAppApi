using CreateCandidate.Data;
using CreateCandidate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreateCandidate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateProfileController : ControllerBase
    {
        private readonly ICandidateProfileRepository _repository;

        public CandidateProfileController(ICandidateProfileRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult<CandidateProfile> CreateCandidateProfile([FromForm] CandidateProfile profile)
        {
            _repository.Add(profile);
          //  _repository.SaveChanges();

            return CreatedAtAction(nameof(GetCandidateProfile), new { id = profile.Id }, profile);
        }

        [HttpGet("{id}")]
        public ActionResult<CandidateProfile> GetCandidateProfile(int id)
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
