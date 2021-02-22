using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET5.Bussiness.Implementations;
using RestWithASPNET5.HyperMedia.Filters;
using RestWithASPNET5.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {


        private readonly ILogger<BookController> _logger;

        private IBookBussiness _bookBussiness;

        public BookController(ILogger<BookController> logger, IBookBussiness bookBussiness)
        {
            _logger = logger;
            _bookBussiness = bookBussiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<BookVO>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]

        public IActionResult Get()
        {

            return Ok(_bookBussiness.FindAll());

        } 
        
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]

        public IActionResult Get(long id)
        {
            var book = _bookBussiness.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);

        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]

        public IActionResult Post([FromBody] BookVO book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBussiness.Create(book));

        }

        [HttpPut]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [TypeFilter(typeof(HyperMediaFilter))]

        public IActionResult Put([FromBody] BookVO book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBussiness.Update(book));

        }

        [HttpDelete("{id}")]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]

        public IActionResult Delete(long id)
        {
            _bookBussiness.Delete(id);
            return NoContent();

        }



    }
}
