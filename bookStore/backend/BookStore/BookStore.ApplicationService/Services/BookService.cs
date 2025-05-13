using BookStore.Core.Models;
using BookStore.DataBase.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookStore.ApplicationService.Services
{
    public class BookService : IBookService
    {
        private readonly IBooksRepository _booksRepository;
        public BookService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _booksRepository.Get();
        }
        public async Task<Guid> CreateBook(Book book)
        {
            return await _booksRepository.Create(book);
        }
        public async Task<Guid> UpdateBook(Guid id, string title, string description, decimal price)
        {
            return await _booksRepository.Update(id, title, description, price);
        }
        public async Task<Guid> DeleteBook(Guid id)
        {
            return await _booksRepository.Delete(id);
        }
    }
}
