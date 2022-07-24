using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagerController : ControllerBase
    {

        // GET api/<MessagerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"value {id.ToString()}";
        }

        // POST api/<MessagerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
