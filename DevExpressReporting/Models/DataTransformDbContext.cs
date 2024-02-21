using Microsoft.EntityFrameworkCore;

namespace DevExpressReporting.Models
{
    public class DataTransformDbContext : DbContext
    {
        public DataTransformDbContext(DbContextOptions<DataTransformDbContext> options)
            : base(options)
        {
        }
        public DbSet<AdcCoreSummary> AdcCoreSummary { get; set; }
    }
}
