using QMS.PSampleService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QMS.PSampleService.Permissions;

public class PSampleServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PSampleServicePermissions.GroupName, L("Permission:PSampleService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PSampleServiceResource>(name);
    }
}
