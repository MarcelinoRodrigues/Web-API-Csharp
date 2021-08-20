using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Myka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        // GET: api/<VagasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "A1" };
        }

        // GET api/<VagasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VagasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VagasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VagasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
