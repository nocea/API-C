using Microsoft.AspNetCore.Mvc;

namespace API_C.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControladorAccesos : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hola";
        }
    }
}
