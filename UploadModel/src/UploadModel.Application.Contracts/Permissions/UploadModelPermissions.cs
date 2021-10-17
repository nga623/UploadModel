using Volo.Abp.Reflection;

namespace UploadModel.Permissions
{
    public class UploadModelPermissions
    {
        public const string GroupName = "UploadModel";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UploadModelPermissions));
        }
    }
}