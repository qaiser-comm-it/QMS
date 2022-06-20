using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QMS.PSampleService.EntityFrameworkCore;

[ConnectionStringName(PSampleServiceDbProperties.ConnectionStringName)]
public interface IPSampleServiceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
