using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace QMS.PSampleService;

[DependsOn(
    typeof(PSampleServiceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class PSampleServiceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(PSampleServiceApplicationContractsModule).Assembly,
            PSampleServiceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PSampleServiceHttpApiClientModule>();
        });

    }
}
