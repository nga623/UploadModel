﻿using AutoMapper;
using Volo.Abp.AuditLogging;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;

namespace Xhznl.HelloAbp
{
    public class HelloAbpApplicationAutoMapperProfile : Profile
    {
        public HelloAbpApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<OrganizationUnit, OrganizationUnitDto>()
                .MapExtraProperties();

            CreateMap<IdentityUserOrgCreateDto, IdentityUserCreateDto>();
            CreateMap<IdentityUserOrgUpdateDto, IdentityUserUpdateDto>();

            CreateMap<IdentityRoleOrgCreateDto, IdentityRoleCreateDto>();

            //AuditLog
            CreateMap<AuditLog, AuditLogDto>()
                .MapExtraProperties();

            CreateMap<EntityChange, EntityChangeDto>()
                .MapExtraProperties();

            CreateMap<EntityPropertyChange, EntityPropertyChangeDto>();

            CreateMap<AuditLogAction, AuditLogActionDto>();

            //Claim
            CreateMap<IdentityClaimType, ClaimTypeDto>().Ignore(x => x.ValueTypeAsString);
            CreateMap<IdentityUserClaim, IdentityUserClaimDto>();
            CreateMap<IdentityUserClaimDto, IdentityUserClaim>().Ignore(x => x.TenantId).Ignore(x => x.Id);
            CreateMap<IdentityRoleClaim, IdentityRoleClaimDto>();
            CreateMap<IdentityRoleClaimDto, IdentityRoleClaim>().Ignore(x => x.TenantId).Ignore(x => x.Id);
            CreateMap<CreateClaimTypeDto, IdentityClaimType>().Ignore(x => x.IsStatic).Ignore(x => x.Id);
            CreateMap<UpdateClaimTypeDto, IdentityClaimType>().Ignore(x => x.IsStatic).Ignore(x => x.Id);
        }
    }
}
