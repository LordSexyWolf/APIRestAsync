using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Greetings()
        { 
            return "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
        }    
    }
}
