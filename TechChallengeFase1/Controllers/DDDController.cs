using Microsoft.AspNetCore.Mvc;
using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechChallengeFase1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDDController : ControllerBase
    {
        private readonly IRepository<DDD> _dddRepository;

        public DDDController(IRepository<DDD> dddRepository)
        {
            _dddRepository = dddRepository;
        }
        // GET: api/<DDDController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "11", "12", "13" };
        }

        // GET api/<DDDController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DDDController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DDDController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DDDController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
