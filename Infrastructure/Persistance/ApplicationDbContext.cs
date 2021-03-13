using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarFeatures> CarFeatures { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }

}
