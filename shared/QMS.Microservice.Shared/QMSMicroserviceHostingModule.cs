using QMS.AdministrationService.EntityFrameworkCore;
using QMS.SaaSService.EntityFrameworkCore;
using QMS.Shared.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace QMS.Microservice.Shared
{
    [DependsOn(
        typeof(QMSHostingModule),
        typeof(AdministrationServiceEntityFrameworkCoreModule),
        typeof(SaaSServiceEntityFrameworkCoreModule)
        )]
    public class QMSMicroserviceHostingModule: AbpModule
    {
    }
}
