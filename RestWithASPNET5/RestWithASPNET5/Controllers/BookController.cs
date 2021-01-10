using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET5.Model;
using RestWithASPNET5.Bussiness.Implementations;

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

        public IActionResult Get()
        {

            return Ok(_bookBussiness.FindAll());

        } 
        
        [HttpGet("{id}")]

        public IActionResult Get(long id)
        {
            var book = _bookBussiness.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);

        }

        [HttpPost]

        public IActionResult Post([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBussiness.Create(book));

        }

        [HttpPut]

        public IActionResult Put([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBussiness.Update(book));

        }

        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            _bookBussiness.Delete(id);
            return NoContent();

        }



    }
}
