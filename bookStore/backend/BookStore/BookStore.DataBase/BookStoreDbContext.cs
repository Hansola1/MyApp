using BookStore.DataBase.Entites;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataBase
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) 
        { }

        public DbSet<BookEntity> Books { get; set; }
    }
}
