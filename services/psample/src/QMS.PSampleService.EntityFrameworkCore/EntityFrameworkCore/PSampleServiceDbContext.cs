using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QMS.PSampleService.EntityFrameworkCore;

[ConnectionStringName(PSampleServiceDbProperties.ConnectionStringName)]
public class PSampleServiceDbContext : AbpDbContext<PSampleServiceDbContext>, IPSampleServiceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public PSampleServiceDbContext(DbContextOptions<PSampleServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigurePSampleService();
    }
}
