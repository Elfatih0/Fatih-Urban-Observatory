using FUO.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace FUO.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<SubSector> Subsectors { get; set; }
        public virtual DbSet<Indicator> Indicators { get; set; }
        public virtual DbSet<SubIndicator> SubIndicators { get; set; }
    }
}
