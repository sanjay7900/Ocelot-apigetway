using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service3.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThirdController : ControllerBase
    {
        public ThirdController() { }
        [HttpPost]
        [Route("Posting")]
        public ActionResult Posting(object name)
        {
            return Ok(name);
        }
    }
}
