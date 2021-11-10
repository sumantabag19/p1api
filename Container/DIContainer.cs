using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EVA.Contract;
using JCI.JEM.Entity.Repository;
using EVA.Contract.Operations.Repository;

using TestApplication.Business;

namespace TestApplication.Container
{
    public class DIContainer
    {
        public static class SQLContainer
        {
            public static void Injector(IServiceCollection services)
            {
                #region Add Context And UnitOfWork

                //Register Context
                services.AddScoped<IUnitOfWork, UnitOfWork>();
                services.AddScoped<IUnitOfWork, UnitOfWork>();


                //services.AddScoped<Microsoft.EntityFrameworkCore.DbContext, LibraryDBContext>();

                #endregion

                #region Logger Utility
                //services.AddScoped<ILogger, Logger>();
                #endregion

                #region Add Repository And Business
                // services.AddScoped<IExecuterSqlProc, SqlProcExecuterRepository>();
                //services.AddScoped<IClassRepository, ClassRepository>();

                //services.AddScoped<IClassBusiness, ClassBusiness>();

                //services.AddScoped<ISieveProcessor, SieveProcessor>();
                //services.AddScoped<ISieveCustomSortMethods, SieveCustomSortMethods>();
                //services.AddScoped<ISieveCustomFilterMethods, SieveCustomFilterMethods>();
                //services.AddScoped<ISieveProcessor, ApplicationSieveProcessor>();


                //services.AddScoped<IOrganizationRepository, OrganizationRepository>();
                //services.AddScoped<IOrganizationBusiness, OrganizationBusiness>();

                //services.AddScoped<IOrgRolesBusiness, OrgRolesBusiness>();
                //services.AddScoped<IOrgRolesRepository, OrgRolesRepository>();

                //services.AddScoped<IUserBusiness, UserBusiness>();
                //services.AddScoped<IUserRepository, UserRepository>();

                //services.AddScoped<ITimeZoneBusiness, TimeZoneBusiness>();
                //services.AddScoped<ITimeZoneRepository, TimeZoneRepository>();

                //services.AddScoped<ICurrencyBusiness, CurrencyBusiness>();
                //services.AddScoped<ICurrencyRepository, CurrencyRepository>();

                //services.AddScoped<IDocumentBusiness, DocumentBusiness>();

                //services.AddScoped<ITeamBusiness, TeamBusiness>();
                //services.AddScoped<ITeamRepository, TeamRepository>();

                //services.AddScoped<IRmUomBusiness, RmUomBusiness>();
                //services.AddScoped<IRmUomRepository, RmUomRepository>();

                #region RMS
                //services.AddScoped<IReportCategoryBusiness, ReportCategoryBusiness>();
                //services.AddScoped<IReportCategoryRepository, ReportCategoryRepository>();
                //services.AddScoped<IMaterialGroupRepository, MaterialGroupRepository>();
                //services.AddScoped<IMaterialGroupBusiness, MaterialGroupBusiness>();
                //services.AddScoped<IPartTypeRepository, PartTypeRepository>();
                //services.AddScoped<IDesignGroupRepository, DesignGroupRepository>();
                //services.AddScoped<IDesignGroupBusiness, DesignGroupBusiness>();
                //services.AddScoped<IPartTypeBusiness, PartTypeBusiness>();
                //services.AddScoped<IDocCategoryBusiness, DocCategoryBusiness>();
                //services.AddScoped<IDocCategoryRepository, DocCategoryRepository>();
                //services.AddScoped<IRalColorBusiness, RalColorBusiness>();
                //services.AddScoped<IRalColorRepository, RalColorRepository>();
                //services.AddScoped<ITechnicalCardBusiness, TechnicalCardsBusiness>();
                //services.AddScoped<ITechnicalCardsRepository, TechnicalCardsRepository>();
                //services.AddScoped<IRmCatalogBusiness, RmCatalogBusiness>();
                //services.AddScoped<IRmCatalogRepository, RmCatalogRepository>();
                //services.AddScoped<IMaterialBusiness, MaterialBusiness>();
                //services.AddScoped<IMaterialRepository, MaterialsRepository>();
                //services.AddScoped<IRmItemsBusiness, RmItemsBusiness>();
                //services.AddScoped<IRmItemsRepository, RmItemsRepository>();
                //services.AddScoped<ICatalogUserBusiness, CatalogUserBusiness>();
                //services.AddScoped<ICatalogUserRepository, CatalogUserRepository>();
                //services.AddScoped<IRiCatalogBusiness, RICatalogBusiness>();
                //services.AddScoped<IRICatalogRepository, RICatalogRepository>();
                //services.AddScoped<IHwCatalogBusiness, HwCatalogBusiness>();
                //services.AddScoped<IHwCatalogRepository, HwCatalogRepository>();
                //services.AddScoped<IRIItemBusiness, RiItemBusiness>();
                //services.AddScoped<IRIItemRepository, RIItemsRepository>();
                //services.AddScoped<IGlassCatalogBusiness, GlassCatalogBusiness>();
                //services.AddScoped<IGlassCatalogRepository, GlassCatalogRepository>();
                //services.AddScoped<IHwRiItemBusiness, HwRIItemBusiness>();
                //services.AddScoped<IHwRiItemRepository, HwRiItemsRepository>();

                //services.AddScoped<IFgSystemBusiness, FgSystemBusiness>();
                //services.AddScoped<IFgSystemRepository, FgSystemRepository>();

                //services.AddScoped<IFgBrandsBusiness, FgBrandsBusiness>();
                //services.AddScoped<IFgBrandRepository, FgBrandsRepository>();

                //services.AddScoped<IFgSystemItemsBusiness, FgSystemItemsBusiness>();
                //services.AddScoped<IFgSystemItemsRepository, FgSystemItemsRepository>();
                //services.AddScoped<IGlassPartTypeBusiness, GlassPartTypeBusiness>();
                //services.AddScoped<IGlassPartTypeRepository, GlassPartTypeRepository>();
                //services.AddScoped<ICatalogDocumentsBusiness, CatalogDocumentsBusiness>();
                //services.AddScoped<IGlassRmItemsBusiness, GlassRmItemsBusiness>();
                //services.AddScoped<IGlassRmItemsRepository, GlassRmItemsRepository>();


                //services.AddScoped<IFgSystemBusiness, FgSystemBusiness>();
                //services.AddScoped<IFgSystemRepository, FgSystemRepository>();
                //services.AddScoped<IFgSystemTypeBusiness, FgSystemTypeBusiness>();
                //services.AddScoped<IFgSystemTypeRepository, FgSystemTypeRepository>();

                //services.AddScoped<IProfileRiRelationshipBusiness, ProfileRiRelationshipBusiness>();
                //services.AddScoped<IProfileRiRelationshipRepository, ProfileRiRelationshipRepository>();
                //services.AddScoped<IGasketRelationshipBusiness, GasketRelationshipBusiness>();
                //services.AddScoped<IGasketRelationshipRepository, GasketRelationshipRepository>();
                //services.AddScoped<IProfileGlassBeadRelationshipBusiness, ProfileGlassBeadRelationshipBusiness>();
                //services.AddScoped<IProfileGlassBeadRelationshipRepository, ProfileGlassBeadRelationshipRepository>();

                #endregion


                #endregion
            }
        }
    }
}
