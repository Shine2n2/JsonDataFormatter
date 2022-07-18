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
        public IActionResult PostPerson(JsonRequestDataDto jsonRequestDto)
        {
            return ok(jsonRequestDto);
        }
    }
}
