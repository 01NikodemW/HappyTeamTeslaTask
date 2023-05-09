using Microsoft.EntityFrameworkCore;

namespace TeslaRentalBackend.Entities;

public class TeslaRentalDbContext : DbContext
{
    public TeslaRentalDbContext(DbContextOptions<TeslaRentalDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = default!;
    public DbSet<Country> Countries { get; set; } = default!;
    public DbSet<Location> Locations { get; set; } = default!;
    public DbSet<Vehicle> Vehicles { get; set; } = default!;
    public DbSet<Reservation> Reservations { get; set; } = default!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.RentalLocation)
            .WithMany()
            .HasForeignKey(r => r.RentalLocationId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Reservation>()
            .HasOne(r => r.ReturnLocation)
            .WithMany()
            .HasForeignKey(r => r.ReturnLocationId)
            .OnDelete(DeleteBehavior.Restrict);
    }

}