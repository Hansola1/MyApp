using BookStore.Core.Models;
using BookStore.DataBase.Entites;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity; обязательно убирай

namespace BookStore.DataBase.Repositories
{
    //CRUD
    public class BooksRepository : IBooksRepository
    {
        private readonly BookStoreDbContext _context;
        public BooksRepository(BookStoreDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> Get()  //Task<T> обобщенный тип, где T — это тип возвращаемого значения.
        {
            var bookEntities = await _context.Books.ToListAsync();

            var books = bookEntities
                .Select(b => Book.Create(b.Id, b.Title, b.Description, b.Price))
                .ToList();

            return books;
        }

        public async Task<Guid> Create(Book book)
        {
            var bookEntity = new BookEntity()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
            };

            await _context.Books.AddAsync(bookEntity);
            await _context.SaveChangesAsync();

            return bookEntity.Id;
        }

        public async Task<Guid> Update(Guid id, string title, string description, decimal price)
        {
            await _context.Books
                .Where(b => b.Id == id)
                .ExecuteUpdateAsync(s => s  //ExecuteUpdateAsync - установим изменения
                    .SetProperty(b => b.Title, b => title)
                    .SetProperty(s => s.Description, description)
                    .SetProperty(s => s.Price, price));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Books
                .Where(b => b.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
