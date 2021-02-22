using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET5.Bussiness.Implementations;
using RestWithASPNET5.Data.VO;
using RestWithASPNET5.HyperMedia.Filters;
using System.Collections.Generic;

namespace RestWithASPNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {


        private readonly ILogger<PersonController> _logger;
        private IPersonBussiness _personBussiness;

        public PersonController(ILogger<PersonController> logger, IPersonBussiness personBussiness)
        {
            _logger = logger;
            _personBussiness = personBussiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<PersonVO>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]

        public IActionResult Get()
        {

            return Ok(_personBussiness.FindAll());

        } 
        
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(PersonVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]

        public IActionResult Get(long id)
        {
            var person = _personBussiness.FindByID(id);
            if (person == null) return NotFound();
            return Ok(person);

        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(PersonVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]

        public IActionResult Post([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();
            return Ok(_personBussiness.Create(person));

        }

        [HttpPut]
        [ProducesResponseType((200), Type = typeof(PersonVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();
            return Ok(_personBussiness.Update(person));

        }

        [HttpDelete("{id}")]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]

        public IActionResult Delete(long id)
        {
            _personBussiness.Delete(id);
            return NoContent();

        }



    }
}
