using Microsoft.EntityFrameworkCore;

namespace sp_az_webapp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Person> Persons { get; set; }   
    }
}
