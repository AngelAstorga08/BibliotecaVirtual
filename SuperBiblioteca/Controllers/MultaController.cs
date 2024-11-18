using API_SuperBiblioteca.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultaController : ControllerBase
    {
        private IMultaService _service;
        public MultaController(IMultaService service) => _service = service;
        // GET: api/<MultaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MultaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MultaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MultaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MultaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
