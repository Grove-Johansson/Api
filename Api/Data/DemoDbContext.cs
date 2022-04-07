using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {

        }

        public DbSet<tblUsers> tblUsers { get; set; }
    }
}
