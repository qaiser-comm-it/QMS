using QMS.PSampleService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QMS.PSampleService;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(PSampleServiceEntityFrameworkCoreTestModule)
    )]
public class PSampleServiceDomainTestModule : AbpModule
{

}
