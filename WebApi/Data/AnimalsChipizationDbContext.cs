using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class AnimalsChipizationDbContext : DbContext
    {
        public AnimalsChipizationDbContext(DbContextOptions<AnimalsChipizationDbContext> options)
            : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }
    }
}
