using JsonDataReader.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace JsonDataReader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonDataRequestController : ControllerBase
    {
        private readonly IJsonConverter _jsonConverter;

        [HttpPost]
        public IActionResult RequestJsonData(GetJsonData getJsonData)
        {
            var result = _jsonConverter.ReadJson(getJsonData);
            if (result == null)
            {
                return BadRequest();  
            }

            return result;
        }


    }
}
