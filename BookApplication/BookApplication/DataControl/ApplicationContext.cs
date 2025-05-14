using BookApplication.Models;
using Microsoft.EntityFrameworkCore; //+Microsoft.EntityFrameworkCore.SqlServer

namespace BookApplication.DataControl
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HANSOLA;Database=bookStore;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

/*----------МИГРАЦИИ----------*/
//Add - Migration InitialCreate
//Update-Database