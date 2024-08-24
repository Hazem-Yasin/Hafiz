using Microsoft.EntityFrameworkCore;
using HafizApi.Models;

namespace HafizApi.Data
{
    public class DataContext : DbContext
    {
        // Constructor to configure the DbContext with options
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // DbSet properties to interact with the database tables
        public DbSet<Ayah> Ayat { get; set; }
        public DbSet<Surah> Surahs { get; set; }

        // Optional: Override OnModelCreating to configure entity relationships and constraints
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure entity relationships, indexes, etc. here if needed
        }
    }
}
