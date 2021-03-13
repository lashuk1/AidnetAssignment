using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        //Classes For Database

        DbSet<Car> Cars { get; set; }
        DbSet<CarFeatures> CarFeatures { get; set; }

        int SaveChanges();
    }
}
