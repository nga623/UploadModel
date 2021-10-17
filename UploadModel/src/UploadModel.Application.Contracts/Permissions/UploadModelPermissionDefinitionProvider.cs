using UploadModel.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace UploadModel.Permissions
{
    public class UploadModelPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(UploadModelPermissions.GroupName, L("Permission:UploadModel"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UploadModelResource>(name);
        }
    }
}