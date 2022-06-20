using QMS.SaaSService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QMS.SaaSService;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(SaaSServiceEntityFrameworkCoreTestModule)
    )]
public class SaaSServiceDomainTestModule : AbpModule
{

}
