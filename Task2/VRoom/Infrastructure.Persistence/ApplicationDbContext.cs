using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Infrastructure.Persistence.Entities;

namespace Infrastructure.Persistence
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;
        public DbSet<IoTData> IoTData { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<ReservationService> ReservationServices { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
