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
        private readonly IService<DDD> _service;

        public DDDController(IService<DDD> service)
        {
            _service = service;
        }
        // GET: api/<DDDController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET api/<DDDController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DDDController>
        [HttpPost]
        public IActionResult Post([FromBody] DDD ddd)
        {
            _service.Create(ddd);
            return Ok();
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
            _service.Delete(id);
        }
    }
}
