using Microsoft.EntityFrameworkCore;

namespace CoronaReportingTool.ApplicationDbContexts
{
    public partial class DataTransformDbContext : DbContext
	{
		public DataTransformDbContext(DbContextOptions<DataTransformDbContext> options)
			: base(options)
		{
		}
		
    }
}
