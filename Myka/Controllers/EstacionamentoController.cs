using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Myka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstacionamentoController : ControllerBase
    {
        // GET: api/<EstacionamentoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "22:08 22:21", "", "HUS2012" };
        }

        // GET api/<EstacionamentoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EstacionamentoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EstacionamentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EstacionamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
