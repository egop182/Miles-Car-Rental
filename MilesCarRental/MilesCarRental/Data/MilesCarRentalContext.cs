using Microsoft.EntityFrameworkCore;
using MilesCarRental.Data.Models;

namespace MilesCarRental.Data
{
    public class MilesCarRentalContext : DbContext
    {
        public MilesCarRentalContext (DbContextOptions<MilesCarRentalContext> options) : base(options)
        {           
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>().ToTable(nameof(Vehiculo));

            base.OnModelCreating(modelBuilder);
        }


    }
}
