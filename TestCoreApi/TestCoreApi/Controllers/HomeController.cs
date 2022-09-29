using Microsoft.AspNetCore.Mvc;

namespace TestCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet(Name = "Getint")]
        public int Get(int id)
        {
            return id;
        }
    }
}
