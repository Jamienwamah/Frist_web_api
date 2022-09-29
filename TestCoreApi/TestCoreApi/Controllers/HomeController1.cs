using Microsoft.AspNetCore.Mvc;

namespace TestCoreApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController1 : Controller
    {
        [HttpGet(Name = "Getstring")]
        public string Get()
        {
            return "I love c#";
        }
    }
}
