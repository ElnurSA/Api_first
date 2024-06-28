using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_First.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            List<string> students = new List<string>() { "Tunzale", "Semed", "Metenat", "Meryem", "Arzu" };
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            return Ok(user.Name + user.Surname);
        }
        
    }
}

