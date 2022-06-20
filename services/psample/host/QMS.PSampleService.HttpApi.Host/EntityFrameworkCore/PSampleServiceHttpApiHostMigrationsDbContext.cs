using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QMS.PSampleService.EntityFrameworkCore;

public class PSampleServiceHttpApiHostMigrationsDbContext : AbpDbContext<PSampleServiceHttpApiHostMigrationsDbContext>
{
    public PSampleServiceHttpApiHostMigrationsDbContext(DbContextOptions<PSampleServiceHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigurePSampleService();
    }
}
