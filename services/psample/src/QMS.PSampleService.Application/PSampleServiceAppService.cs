using QMS.PSampleService.Localization;
using Volo.Abp.Application.Services;

namespace QMS.PSampleService;

public abstract class PSampleServiceAppService : ApplicationService
{
    protected PSampleServiceAppService()
    {
        LocalizationResource = typeof(PSampleServiceResource);
        ObjectMapperContext = typeof(PSampleServiceApplicationModule);
    }
}
