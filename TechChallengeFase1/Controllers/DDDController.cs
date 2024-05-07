using Microsoft.AspNetCore.Mvc;
using TechChallengeFase1.DTOs;
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
            var ddds = _service.GetAll();
            return Ok(ddds);
        }

        // GET api/<DDDController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dddById = _service.GetById(id);
            return Ok(dddById);
        }

        // POST api/<DDDController>
        [HttpPost]
        public IActionResult Post([FromBody] DDDdto dddInputed)
        {
            DDD ddd = new DDD { Number = dddInputed.Number,Regiao=dddInputed.Regiao, Contacts = [] } ;
            _service.Create(ddd);
            return Ok();
        }

        // PUT api/<DDDController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DDDdto dddInputed)
        {
            DDD ddd = new DDD { Number = dddInputed.Number, Regiao = dddInputed.Regiao, Contacts = [] };
            _service.Update(id, ddd);
        }

        // DELETE api/<DDDController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

        // GET api/<DDDController>/FindNumber/5
        [HttpGet("/FindNumber/{number}")]
        public IActionResult GetNumber(int number)
        {
            return Ok(_service.GetAll().Where(ddd => ddd.Number == number).SingleOrDefault() ?? null);
        }
    }
}
