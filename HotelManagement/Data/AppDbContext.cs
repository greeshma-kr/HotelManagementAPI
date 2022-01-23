using Microsoft.EntityFrameworkCore;


namespace HotelManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Reviews> Reviews { get; set; }

        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<HotelImages> HotelImages { get; set; }
        public DbSet<Rating> Rating { get; set; }

        public DbSet<Reservation> Reservation { get; set; }

        public DbSet<Guests> Guests { get; set; }


    }
}
