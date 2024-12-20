using Microsoft.AspNetCore.Mvc;

namespace service1.api.Controllers
{
    [Route("api/[Controller]")]    
    public class FirstController : ControllerBase
    {
        public FirstController()
        {
            
        }

        [HttpGet]
        [Route("ShowPayments")]
        public ActionResult ShowPayments()
        {

            return Ok($"{0009} = {9294940949484} Amount");

        }

    }
}
