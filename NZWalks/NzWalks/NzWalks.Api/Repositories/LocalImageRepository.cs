using NzWalks.Api.Models.Domain;

namespace NzWalks.Api.Repositories
{
    public class LocalImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task<Image> Upload(Image image)
        {

            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", image.FileName, image.FileExtension);

            using var stream = new FileStream (localFilePath, FileMode.Create);

            await image.File.CopyToAsync (stream);

            
        }
    }
}
