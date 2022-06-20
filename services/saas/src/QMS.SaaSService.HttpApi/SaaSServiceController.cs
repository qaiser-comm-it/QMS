using QMS.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QMS.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
