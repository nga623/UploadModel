﻿using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;
using Xhznl.HelloAbp.Users;

namespace Xhznl.HelloAbp.EntityFrameworkCore
{
    public static class HelloAbpEfCoreEntityExtensionMappings
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            HelloAbpModulePropertyConfigurator.Configure();

            OneTimeRunner.Run(() =>
            {
                /* You can configure entity extension properties for the
                 * entities defined in the used modules.
                 *
                 * The properties defined here becomes table fields.
                 * If you want to use the ExtraProperties dictionary of the entity
                 * instead of creating a new field, then define the property in the
                 * HelloAbpDomainObjectExtensions class.
                 *
                 * Example:
                 *
                 * ObjectExtensionManager.Instance
                 *    .MapEfCoreProperty<IdentityUser, string>(
                 *        "MyProperty",
                 *        b => b.HasMaxLength(128)
                 *    );
                 *
                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
                 */

                ObjectExtensionManager.Instance
                    .MapEfCoreProperty<IdentityUser, string>(
                        nameof(AppUser.Avatar),
                        (entityBuilder, propertyBuilder) =>
                        {
                            propertyBuilder.HasMaxLength(AppUserConsts.MaxAvatarLength);
                        }
                    )
                    .MapEfCoreProperty<IdentityUser, string>(
                        nameof(AppUser.Introduction),
                        (entityBuilder, propertyBuilder) =>
                        {
                            propertyBuilder.HasMaxLength(AppUserConsts.MaxIntroductionLength);
                        }
                    );
            });
        }
    }
}