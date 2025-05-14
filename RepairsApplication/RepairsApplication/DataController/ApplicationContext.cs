using Microsoft.EntityFrameworkCore;

namespace RepairsApplication.DataController
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Request> Requests { get; set; } 
        public DbSet<Master> Masters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DANICHLAPTOP;Database=EducationPlans;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
