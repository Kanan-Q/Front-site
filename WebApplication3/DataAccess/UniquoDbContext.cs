using Microsoft.EntityFrameworkCore;

namespace WebApplication3.DataAccess
{
    public class UniquoDbContext:DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public UniquoDbContext(DbContextOptions opt):base(opt) { }
    }
}
