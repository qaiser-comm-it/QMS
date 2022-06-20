using QMS.PSampleService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QMS.PSampleService;

public abstract class PSampleServiceController : AbpControllerBase
{
    protected PSampleServiceController()
    {
        LocalizationResource = typeof(PSampleServiceResource);
    }
}
