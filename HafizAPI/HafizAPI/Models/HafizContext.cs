using Microsoft.EntityFrameworkCore;

namespace HafizApi.Models
{
    public class HafizContext : DbContext
    {
        public DbSet<Ayah> Ayat { get; set; }
        public DbSet<Surah> Surahs { get; set; }

        public HafizContext(DbContextOptions options) : base(options)
        {

        }
    }
}
