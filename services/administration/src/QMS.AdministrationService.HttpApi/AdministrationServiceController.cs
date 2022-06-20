using QMS.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QMS.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
