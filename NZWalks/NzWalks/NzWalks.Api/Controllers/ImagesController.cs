using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NzWalks.Api.Models.DTO;

namespace NzWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {

        //Post: /api/images/Upload
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto request)
        {
            ValidateFileUpload(request);

            if (ModelState.IsValid)
            {

                // convert DTO to Domain Model  

                var imageDomainModel = new Image
                {
                    File = request.File,
                    FileExtension = Path.GetExtension(request.File.FileName),
                    FileSizeInBytes = request.File.Length,
                    FileName = request.FileName,
                    FileDescription = request.FileDescription,

                };
                //User repository t upload image 
            }

            return BadRequest(ModelState);

        }

        private void ValidateFileUpload (ImageUploadRequestDto requestDto)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
            if (allowedExtensions.Contains(Path.GetExtension(Request.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported File Extension");
            }

            if (reguest.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size more than 10MB")
            }

        }
    }
}
