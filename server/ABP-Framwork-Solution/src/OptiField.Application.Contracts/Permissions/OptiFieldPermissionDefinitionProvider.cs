using OptiField.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OptiField.Permissions;

public class OptiFieldPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OptiFieldPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OptiFieldPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OptiFieldResource>(name);
    }
}
