using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CandidateProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateProfileController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> GetImageUrl()
        {
            try
            {
                
                string imageUrl = "https://your.s3.bucket.com/image.jpg";

                return Ok(imageUrl);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
