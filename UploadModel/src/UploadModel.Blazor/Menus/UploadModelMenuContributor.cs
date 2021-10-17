using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace UploadModel.Blazor.Menus
{
    public class UploadModelMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(UploadModelMenus.Prefix, displayName: "UploadModel", "/UploadModel", icon: "fa fa-globe"));
            
            return Task.CompletedTask;
        }
    }
}