using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace QMS.PSampleService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PSampleServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class PSampleServiceConsoleApiClientModule : AbpModule
{

}
