using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Myka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        // GET: api/<Funcionarios>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "Ino" };
        }

        // GET api/<Funcionarios>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Funcionarios>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Funcionarios>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Funcionarios>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
