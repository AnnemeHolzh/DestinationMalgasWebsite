using DestinationMalgasWebsite.DBModels;
using Microsoft.EntityFrameworkCore;

namespace DestinationMalgasWebsite.Data
{
    public class DMDBContext : DbContext
    {
        public DMDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<PropertyPhoto> PropertyPhotos { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<PropertyAmenity> PropertyAmenities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyAmenity>()
                .HasKey(pa => new { pa.PropertyID, pa.AmenityID });

            modelBuilder.Entity<PropertyAmenity>()
                .HasOne(pa => pa.Property)
                .WithMany(p => p.PropertyAmenities)
                .HasForeignKey(pa => pa.PropertyID);

            modelBuilder.Entity<PropertyAmenity>()
                .HasOne(pa => pa.Amenity)
                .WithMany(a => a.PropertyAmenities)
                .HasForeignKey(pa => pa.AmenityID);

            base.OnModelCreating(modelBuilder);
        }

    }
}
