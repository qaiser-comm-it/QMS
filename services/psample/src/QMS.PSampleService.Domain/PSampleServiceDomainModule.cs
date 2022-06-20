using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace QMS.PSampleService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(PSampleServiceDomainSharedModule)
)]
public class PSampleServiceDomainModule : AbpModule
{

}
