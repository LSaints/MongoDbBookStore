using Microsoft.AspNetCore.Mvc;
using MongoDbBookStore.Models;
using MongoDbBookStore.Services;

namespace MongoDbBookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookServices _services;

        public BookController(BookServices services) =>
            _services = services;

        [HttpGet]
        public async Task<List<Book>> Get() =>
            await _services.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Book>> Get(string id)
        {
            var book = await _services.GetAsync(id);

            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Book newBook)
        {
            await _services.CreateAsync(newBook);
            return CreatedAtAction(nameof(Get), new {id = newBook.Id}, newBook);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Book updatedBook)
        {
            var book = await _services.GetAsync(id);

            if(book == null)
            {
                return NotFound();
            }
            updatedBook.Id = book.Id;
            await _services.UpdateAsync(id, updatedBook);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _services.GetAsync(id);
            if(book == null)
            {
                return NotFound();
            }
            await _services.RemoveAsync(id);
            return NoContent();
        }
    }
}
