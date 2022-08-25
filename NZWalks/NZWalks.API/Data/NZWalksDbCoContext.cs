using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbCoContext:DbContext
    {
        public NZWalksDbCoContext(DbContextOptions<NZWalksDbCoContext> options):base(options)
        {
                
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
