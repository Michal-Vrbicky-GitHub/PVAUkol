using Microsoft.EntityFrameworkCore;
using PVA_Zapoctovy_ukol.Models;

namespace PVA_Zapoctovy_ukol.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Credit> Credits { get; set; }
    }
}
