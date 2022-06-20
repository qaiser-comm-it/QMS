using QMS.AdministrationService;
using QMS.AdministrationService.EntityFrameworkCore;
using QMS.IdentityService;
using QMS.IdentityService.EntityFrameworkCore;
using QMS.SaaSService;
using QMS.SaaSService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace QMS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AdministrationServiceEntityFrameworkCoreModule),
        typeof(AdministrationServiceApplicationContractsModule),
        typeof(IdentityServiceEntityFrameworkCoreModule),
        typeof(IdentityServiceApplicationContractsModule),
        typeof(SaaSServiceEntityFrameworkCoreModule),
        typeof(SaaSServiceApplicationContractsModule)
        )]
    //typeof(QMSHostingModule)
    public class QMSDbMigratorModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
           
        }
    }
}
