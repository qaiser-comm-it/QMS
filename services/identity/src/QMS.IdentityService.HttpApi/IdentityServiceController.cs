using QMS.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QMS.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
