using Microsoft.EntityFrameworkCore;

using SharedData.Models;




namespace WebApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<GameResult> GameResults { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}
