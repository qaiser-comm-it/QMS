using Localization.Resources.AbpUi;
using QMS.PSampleService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace QMS.PSampleService;

[DependsOn(
    typeof(PSampleServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class PSampleServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(PSampleServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PSampleServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
