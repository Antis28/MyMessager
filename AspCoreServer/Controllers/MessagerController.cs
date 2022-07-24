using ConsoleClient;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagerController : ControllerBase
    {
        private static List<Message> messages = new List<Message>();
        // GET api/<MessagerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string outputString = "Not found";
            if (id < messages.Count && id >= 0)
            {
                outputString = JsonConvert.SerializeObject(messages[id]);
            }
            Console.WriteLine($"Запрошено сообщение #{id}: {outputString}");
            return outputString;
        }

        // POST api/<MessagerController>
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if(msg == null)
            {
                return BadRequest();
            }
            messages.Add(msg);
            Console.WriteLine($"Всего сообщений: {messages.Count}, посланное сообщение: {msg}");
            return new OkResult(); 
        }
    }
}
