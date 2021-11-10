using System;

namespace TestApplication.Common.Constants
{
    public static class KeyConstant
    {
        public const string JWKS = ".well-known/jwks";
        public const string UnauthorizedAccess = "UnauthorizedAccess";
        public const string InvalidAccessToken = "InvalidAccessToken";
        public const string InternalServerError = "InternalServerError";
        public const string ConnectionString = "ConnectionString";


        public const string ImsClaim = "ImsClaim";
        public const string OrgId = "org";
        public const string OrgRoleId = "org_role";
        public const string DataAccessTypeId = "data_access";
        public const string AppOrgId = "aoid";
        public const string AppUserId = "auid";
        public const string Client_Type = "client_type";
        public const string UserName = "username";
        public const string Role = "role";
        public const string AppName = "app";
        public const string RefreshToken = "refresh_token";
        public const string Subid = "subid";
        public const string Sub = "sub";
        public const string Client = "Client";
        public const string Passwordexpireat = "passwordexpireat";
        public const string RemainingDays = "passwordexpireindays";
        public const string Audience = "audience";
        public const string AudienceKey = "audienceKey";
        public const string JWT = "JWT";
        public const string ClientId = "client_id";
        public const string TenantId = "tid";
        public const string AccessToken = "token";
        public const string UsersHeader = "users";

        public static string SiteAdmin = "SiteAdmin";
        public static string SuperAdmin = "SuperAdmin";
        public static string ServiceClient = "ServiceClient";
        public static string SiteUser = "SiteUser";
    }

    public class ProcedureConstants
    {
        public const string GetOrganizationListWithDatabaseName = "GetOrganizationListWithDatabaseName";
        public const string GetDatabaseNameWithDataHealthNotification = "GetDatabaseNameWithDataHealthNotification";
        public const string AddOrganizationCreateDatabaseMaintainDatabaseConnection = "sp_AddOrganizationCreateDatabaseMaintainDatabaseConnection";
        public const string sp_AddOrganizationCreateDatabaseMaintainDatabaseConnection_Logic = "sp_AddOrganizationCreateDatabaseMaintainDatabaseConnection_Logic";

        public const string DeleteOrganization = "spDeleteOrganization";
        public const string GetUserHierarchy = "GetUserHierarchy";
        public const string GetHierarchialUserIds = "GetHierarchialUserIds";
        public const string sp_GetUserList = "sp_GetUserList";
        public const string sp_GetQuotationDetails = "sp_GetQuotationDetails";
        public const string sp_GetRoleBasedReportWithRolesId = "sp_GetRoleBasedReportWithRolesId";
        public const string sp_GetAllReportFormtName = "sp_GetAllReportFormtName";
        public const string sp_GetDesignAssemblyReport = "sp_GetDesignAssemblyReport";
        



        //for AddtagGroup
        public const string sp_AddTagGroup = "sp_AddTagGroup";
        public const string GetPartsData = "GetPartsData";
        public const string GetHeaderWithDisplay = "GetHeaderWithDisplay";
        public const string GetHeaderWithDisplayDemo = "GetHeaderWithDisplayDemo";
        public const string sp_GetDisplayData = "sp_GetDisplayData";
        public const string GetTagDIsplay = "GetTagDIsplay";
        public const string sp_AddContact = "sp_AddContact";
        public const string sp_AdditionalContact = "sp_AdditionalContact";
        public const string sp_AddManageContact = "sp_AddManageContact";
        public const string sp_AddLabelContact = "sp_AddLabelContact";
        public const string sp_AddAccount = "sp_AddAccount";
        public const string sp_UpdateAccount = "sp_UpdateAccount";
        public const string sp_GetAccountMasterList = "sp_GetAccountMasterList";
        public const string sp_EditAccount = "sp_EditAccount";
        public const string sp_GetAccountList = "sp_GetAccountList";
        public const string sp_GetAccounttMasterList = "sp_GetAccounttMasterList";
        public const string sp_GetAllUserHierarchy = "sp_GetAllUserHierarchy";
        public const string sp_GetUserHierarchy = "sp_GetUserHierarchy"; 
        public const string sp_AddTest = "sp_AddTest";
        public const string sp_AddTest1 = "sp_AddTest1";
        public const string sp_AddTest2 = "sp_AddTest2";

        public const string sp_UpdateEvaContact = "sp_UpdateEvaContact";
        public const string sp_EditContact = "sp_EditContact";
        public const string sp_AddEvaContact = "sp_AddEvaContact";
        public const string sp_GetContactList = "sp_GetContactList";
        public const string sp_deleteContact = "sp_deleteContact";
        public const string sp_GetAccountDetails = "sp_GetAccountDetails";
        public const string sp_GetUserDetails = "sp_GetUserDetails";
        public const string sp_UpdateCurrency = "sp_UpdateCurrency";
        public const string sp_GetAccountName = "sp_GetAccountName";
        public const string sp_EditUserData = "sp_EditUserData";
        public const string sp_UpdateUser = "sp_UpdateUser";
        public const string sp_deleteAccount = "sp_deleteAccount";
        public const string sp_GetRestrictUserForDeadlock = "sp_GetRestrictUserForDeadlock";

        public const string sp_TestCache = "sp_TestCache";
        public const string sp_AddDefaultCounter = "sp_AddDefaultCounter";
        public const string sp_GetOpportunityList = "sp_GetOpportunityList";
        public const string sp_GetOpportunityListGrid = "sp_GetOpportunityListGrid";
        public const string sp_GetOpportunityQuoteList = "sp_GetOpportunityQuoteList";
        public const string sp_GetQuoteLineItemList = "sp_GetQuoteLineItemList";  
        public const string sp_GetContactMasterList = "sp_GetContactMasterList";
        public const string sp_deleteTeam = "sp_deleteTeam";
        public const string sp_getTeamList = "sp_getTeamList";
        public const string sp_getmaxheaderorderno = "sp_getmaxheaderorderno";

        public const string sp_GetTasksAndLogsSummary = "sp_GetTasksAndLogsSummary";
        public const string sp_GetTasksAndLogsList = "sp_GetTasksAndLogsList";
        public const string sp_GetOrgRolesList = "sp_GetOrgRolesList";
        public const string sp_OpportunitySourceList = "sp_OpportunitySourceList";
        public const string sp_OpportunityStageList = "sp_OpportunityStageList";
        public const string sp_GetAllOpportunity = "sp_GetAllOpportunity";
        public const string sp_GetOpportunityLostReasonOptionList = "sp_GetOpportunityLostReasonOptionList";
        public const string sp_GetOpportunityLostCompetitorOptionList = "sp_GetOpportunityLostCompetitorOptionList";

        public const string sp_GetOpportunityCountWidget = "sp_GetOpportunityCountWidget";
        public const string sp_GetLostReasonsWidget = "sp_GetLostReasonsWidget";
        public const string sp_GetStagewiseActiveOpportunitiesWidget = "sp_GetStagewiseActiveOpportunitiesWidget";
        public const string sp_GetSourcewiseOpportunitiesWidget = "sp_GetSourcewiseOpportunitiesWidget";
        public const string sp_GetLocationwiseOpportunitiesWidget = "sp_GetLocationwiseOpportunitiesWidget";
        public const string sp_GetTeamwiseWonOpportunitiesWidget = "sp_GetTeamwiseWonOpportunitiesWidget";


        #region "RMS"
        public const string USP_GETProfileRMCatalogList = "USP_GETProfileRMCatalogList";
        public const string USP_GETRICatalogList = "USP_GETRICatalogList";
        public const string USP_GETHwCatalogList = "USP_GETHwCatalogList";
        public const string USP_GETProfileRMItemList = "USP_GETProfileRMItemList";
        public const string USP_GETRIRMItemList = "USP_GETRIRMItemList";
        public const string USP_GETGlassCatalogList = "USP_GETGlassCatalogList";
        public const string USP_GETHwRiItemsList = "USP_GETHwRiItemsList";
        public const string USP_GetGlassRMItems = "USP_GetGlassRMItems";

        public const string sp_GetFgSystemList = "sp_GetFgSystemList";
        public const string sp_GetAllocatedFgSystemRmItemList = "sp_GetAllocatedFgSystemRmItemList";
        public const string sp_GetProfileRIRelationshipList = "sp_GetProfileRIRelationshipList";
        public const string sp_GetGasketRelationshipList = "sp_GetGasketRelationshipList";
        public const string sp_GetProfileGlassBeadRelationshipList = "sp_GetProfileGlassBeadRelationshipList";
        
        public const string sp_getRelatedCatlogName = "sp_getRelatedCatlogName";
        public const string sp_GetRmSystemListForAdd = "sp_GetRmSystemListForAdd";
        public const string sp_GetBrandList = "sp_GetBrandList";
        public const string sp_GetSystemNameWithBrandWise = "sp_GetSystemNameWithBrandWise";
        public const string sp_GetAllFgSystemeWithOrganisation = "sp_GetAllFgSystemeWithOrganisation";
        public const string sp_GetAllFgBrandWithSystem = "sp_GetAllFgBrandWithSystem";
        public const string sp_GetOrgFgSystemList = "sp_GetOrgFgSystemList";
        public const string sp_GetCatalogItemList = "sp_GetCatalogItemList";
        public const string sp_GetFgSystemTypeList = "sp_GetFgSystemTypeList";
        
        #endregion
    }

    public static class Resource
    {
        public const string Msg_Delete = "Record deleted successfully";
        public const string Msg_ErrorDelete = "Record not deleted";
        public const string Msg_ErrorInsert = "Record not inserted";
        public const string Msg_ErrorUpdate = "record not updated";
        public const string Msg_Insert = "record inserted successfully";
        public const string Msg_Update = "record updated successfully";


        public const string ErrorMsg_ModelNull = "Model is null";
    }
}
