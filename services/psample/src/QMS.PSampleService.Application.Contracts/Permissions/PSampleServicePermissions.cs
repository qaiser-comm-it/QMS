using Volo.Abp.Reflection;

namespace QMS.PSampleService.Permissions;

public class PSampleServicePermissions
{
    public const string GroupName = "PSampleService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(PSampleServicePermissions));
    }
}
