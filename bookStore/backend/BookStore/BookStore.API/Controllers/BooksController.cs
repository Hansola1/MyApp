using BookStore.API.Contracts;
using BookStore.ApplicationService.Services;
using BookStore.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers //Создаем API
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _booksServices;

        public BooksController(IBookService booksServices) 
        {
            _booksServices = booksServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<BooksResponse>>> GetBooks()
        {
            var books = await _booksServices.GetAllBooks();
            var response = books.Select(b => new BooksResponse(b.Id, b.Title, b.Description, b.Price));

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateBook([FromBody] BooksRequest request) //получаем с фронта
        {
            var book = Book.Create(
                Guid.NewGuid(),
                request.Title,
                request.Description,
                request.Price);

            var bookId = await _booksServices.CreateBook(book);
            return Ok(bookId);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateBook(Guid id, [FromBody] BooksRequest request)
        {
            var bookId = await _booksServices.UpdateBook(id, request.Title, request.Description, request.Price);
            return Ok(bookId);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteBook(Guid id)
        {
            var bookId = await _booksServices.DeleteBook(id);
            return Ok(bookId);
        }
    }
}
