using froggo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace froggo.API.Data;

public class WaterQualityDbContext : DbContext
{
    public WaterQualityDbContext(DbContextOptions<WaterQualityDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<WaterQualityData> WaterQualityDatas { get; set; }
}