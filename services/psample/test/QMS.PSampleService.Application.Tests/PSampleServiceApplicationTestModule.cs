using Volo.Abp.Modularity;

namespace QMS.PSampleService;

[DependsOn(
    typeof(PSampleServiceApplicationModule),
    typeof(PSampleServiceDomainTestModule)
    )]
public class PSampleServiceApplicationTestModule : AbpModule
{

}
