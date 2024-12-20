using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service2.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecondController : ControllerBase
    {
        public SecondController()
        {
            
        }

        [HttpGet]
        [Route("Write")]
        public ActionResult Write(string name)
        {
            return Ok($" u write {name}");        
        }

        
    }
}
