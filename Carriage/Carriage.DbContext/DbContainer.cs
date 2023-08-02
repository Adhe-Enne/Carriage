using Microsoft.EntityFrameworkCore;

namespace Carriage.DataBaseContext
{
    public class DbContainer : DbContext
    {
        public DbContainer()
        {
        }

        public DbContainer(DbContextOptions<DbContainer> options)
            : base(options)
        {
        }

        public virtual DbSet<Carriage.Models.Enitities.Car> Cars { get; set; } = null!;
        public virtual DbSet<Carriage.Models.Enitities.Manufacturer> Manufacturers { get; set; } = null!;

    }
}
