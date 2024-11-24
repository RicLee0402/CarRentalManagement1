using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement1.Data;
using CarRentalManagement1.Configurations;

namespace CarRentalManagement1.Data
{
    public class CarRentalManagement1Context(DbContextOptions<CarRentalManagement1Context> options) : IdentityDbContext<CarRentalManagement1User>(options)
    {
        public DbSet<CarRentalManagement1.Domains.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domains.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domains.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domains.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domains.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement1.Domains.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
