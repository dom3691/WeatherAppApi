using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getUserImage.Interface
{
    public interface IGetImageService
    {

        Task<UserDetails> GetImageAndDetails(UserDetails userDetails);
    }
}
