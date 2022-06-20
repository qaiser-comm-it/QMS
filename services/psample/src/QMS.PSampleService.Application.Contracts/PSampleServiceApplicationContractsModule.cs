using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace QMS.PSampleService;

[DependsOn(
    typeof(PSampleServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class PSampleServiceApplicationContractsModule : AbpModule
{

}
