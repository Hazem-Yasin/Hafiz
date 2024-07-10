using HafizApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HafizApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Ayah> Ayat { get; set; }
        public DbSet<Surah> Surahs { get; set; }
    }
}


