using Microsoft.AspNetCore.Mvc;
using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechChallengeFase1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IService<Contact> _service;

        public ContactController(IService<Contact> contactService)
        {
            _service = contactService;
        }

        // GET: api/<ContactController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetById(id));
        }

        // POST api/<ContactController>
        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            _service.Create(contact);
            return Ok();
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Contact contact)
        {
            _service.Update(id, contact);
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
