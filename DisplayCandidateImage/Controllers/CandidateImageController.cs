using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DisplayCandidateImage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateImageController : ControllerBase
    {
        //var s3Client = new AmazonS3Client(AWS_ACCESS_KEY_ID, AWS_SECRET_ACCESS_KEY, RegionEndpoint.USEast1);
        private readonly IAmazonS3 _s3Client;
        private const string BUCKET_NAME = "test-bucket-imagedisplay";


        public CandidateImageController(IAmazonS3 s3Client)
        {
            _s3Client = s3Client;
        }

       


        [HttpGet("{key}")]
        public async Task<IActionResult> GetImage(string key)
        {
            try
            {
                var response = await _s3Client.GetObjectAsync(BUCKET_NAME, key);

                using (var stream = response.ResponseStream)
                {
                    var memoryStream = new MemoryStream();  
                    await stream.CopyToAsync(memoryStream);
                    memoryStream.Position = 0;

                    return File(memoryStream, response.Headers.ContentType, key);
                }
            }
            catch (AmazonS3Exception e)
            {
                // handle exception
                return BadRequest();


                //private readonly IAmazonS3 _s3Client;
                //private readonly string _bucketName;

                //public CandidateImageController(IAmazonS3 s3Client)
                //{
                //    _s3Client = s3Client;
                //    _bucketName = "test-bucket-imagedisplay";
                //}


                //[HttpGet("2ndGetRequest")]

                //public async Task ViewImage(string fileName)
                //{
                //    AmazonS3Client clients = new AmazonS3Client(fileName, _bucketName);

                //    GetObjectRequest request = new GetObjectRequest
                //    {
                //        BucketName = _bucketName,
                //        Key = fileName
                //    };

                //    using GetObjectResponse response = await clients.GetObjectAsync(request);
                //    using (StreamReader reader = new StreamReader(response.ResponseStream))
                //    {
                //        string contents = reader.ReadToEnd();

                //    }
                //}

                //[HttpPost("uploadCandidateImage")]
                //public async Task<IActionResult> UploadImage(IFormFile file)
                //{
                //    if (file == null || file.Length == 0)
                //    {
                //        return BadRequest("Please provide an image file to upload.");
                //    }

                //    var key = Path.GetFileName(file.FileName);

                //    using (var stream = file.OpenReadStream())
                //    {
                //        var putObjectRequest = new PutObjectRequest
                //        {
                //            BucketName = _bucketName,
                //            Key = key,
                //            InputStream = stream,
                //            ContentType = file.ContentType
                //        };

                //        try
                //        {
                //            await _s3Client.PutObjectAsync(putObjectRequest);
                //        }
                //        catch (AmazonS3Exception ex)
                //        {
                //            // Handle exception
                //            return StatusCode(500, ex.Message);
                //        }
                //    }

                //    return Ok($"Image uploaded to S3 bucket {_bucketName} with key {key}");
                //}

                // [HttpGet("displayCandidateImage {key}")]
                //public IActionResult Get(string key)
                //{
                //    var getObjectRequest = new GetObjectRequest
                //    {
                //        BucketName = _bucketName,
                //        Key = key
                //    };

                //    try
                //    {
                //        var response = _s3Client.GetObjectAsync(getObjectRequest).GetAwaiter().GetResult();
                //        return File(response.ResponseStream, response.Headers.ContentType, key);
                //    }
                //    catch (AmazonS3Exception ex)
                //    {
                //        // Handle exception
                //        return StatusCode(500, ex.Message);
                //    }
                //}

                //public string BucketName = "test-bucket-imagedisplay";


                //[HttpGet("getCandidateImage")]
                //public async Task<IActionResult> GetImage(string fileName)
                //{
                //    var client = new AmazonS3Client();
                //    var response = await client.GetObjectAsync(BucketName, fileName);

                //    return File(response.ResponseStream, response.Headers.ContentType);

                //}

                //[HttpPost]
                //public async Task Post(IFormFile formFile)
                //{
                //    var client = new AmazonS3Client();
                //    var bucketRequest = new PutBucketRequest()
                //    {
                //        BucketName = BucketName,
                //        UseClientRegion = true

                //    };
                //    await client.PutBucketAsync(bucketRequest);
                //}



                //[HttpGet]
                //public async Task<ActionResult<string>> GetImageUrl()
                //{
                //    try
                //    {
                //        //to retrieve the image URL from S3
                //        string imageUrl = "https://test-bucket-imagedisplay.s3.bucket.com";

                //        if (string.IsNullOrEmpty(BucketName))
                //        {
                //            return NotFound("No Image Found");
                //        }

                //        if (string.ReferenceEquals(imageUrl, BucketName))
                //        {
                //            return Ok();

                //        }

                //        return Ok(imageUrl);
                //    }
                //    catch (Exception ex)
                //    {
                //        return BadRequest(ex.Message);
                //    }
                //}
            }
        }
    }
}
