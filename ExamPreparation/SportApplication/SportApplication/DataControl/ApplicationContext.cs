using SportApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace SportApplication.DataControl
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Inventory> Invetoryes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HANSOLA;Database=SportBase;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
