using Microsoft.EntityFrameworkCore;

namespace gas_station
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext(DbContextOptions<WebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<Login> Login { get; set; }
    }
}
