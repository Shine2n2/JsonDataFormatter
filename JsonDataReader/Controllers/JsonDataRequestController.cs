using JsonDataReader.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JsonDataReader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonDataRequestController : ControllerBase
    {
        [HttpPost]
        public IActionResult RequestJsonData(GetJsonData getJsonData)
        {
            return null;
        }


    }
}
