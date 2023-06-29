using HelloCoreApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelloCoreApp.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private List<ItemModel> LoadList()
        {
            return new List<ItemModel>();
        }
    }
}
