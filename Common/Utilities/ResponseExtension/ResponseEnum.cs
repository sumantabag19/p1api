using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;

namespace TestApplication.Common.Utilities.ResponseExtension
{
    public static class ResponseEnumExtensions
    {
        // Create an instance of the ResourceManager class, and store it as a static variable
        // so the same instance can be used multiple times.  Note that the
        // [typeof(MyProjectResources)] assumes that the strings are stored in a resource file
        // named "MyProjectResources.resx", so that will need to be changed to the class type
        // that is created for your resource.  Static fields do not have to start with "s_",
        // but that is what I like to do.

        private static ResourceManager s_ResourceManager = new ResourceManager(typeof(ResponseMessages));

        // This is an extension method for the type [MyEnum] because it is a static method on
        // a static class, and the first parameter is of type [this MyEnum].

        public static string GetDescription(this ResponseEnum value)
        {
            // Define a string format that will be used if the matching value is not found in
            // the resource file.  Hopefully that does not happen because programmers will
            // remember to keep the resource updated as elements are changed or added to the
            // enum, but better to be safe than sorry.

            const string RESOURCE_NOT_FOUND_FORMAT = "Unable to find string resource for resource key '{0}'.";

            // Use the ResourceManager instance to lookup the key that is the name of the enum
            // element ("Alpha", "Bravo", "Charlie").  If the resource is found then return the
            // string from the resource file.  But, if the resource is not found the
            // [GetString()] method will return null, which means the ?? operator will execute
            // the [String.Format()] to build a default string.

            return s_ResourceManager.GetString(value.ToString()) ?? String.Format(RESOURCE_NOT_FOUND_FORMAT, value);
        }
    }

    public enum ResponseEnum
    {
        //Common_DataFetchSuccess = 999,
        //Common_DataSaveMsg = 1000,
        //Err_DataSaveFailed = 1099,
        //Err_MobileAlreadyExist = 1001,
        //Err_UsernameAlreadyExist = 1002,
        //Err_EmailAlreadyExist = 1003,
        //Err_InvalidAccessToken = 1004,
        //Err_UnhandledException = 1098,
        //Err_InvalidHmacToken = 1097,
        //Registration_Success = 2001,
        //Err_HdrNameAlreadyExist=5000


        Common_DataFetchSuccess = 999,
        Common_DataSaveMsg = 1000,
        Err_MobileAlreadyExist = 1001,
        Err_UsernameAlreadyExist = 1002,
        Err_EmailAlreadyExist = 1003,
        Err_InvalidAccessToken = 1004,
        Err_DataSaveFailed = 1099,
        Err_UnhandledException = 1098,
        Err_InvalidHmacToken = 1097,
        Err_InvalidOpportunity = 1096,
        Err_InconsistentData= 1095,
        Registration_Success = 2001,
        Common_DataDeleteMsg = 2002,
        Common_DataDeleteFailedMsg = 2003,
        Common_DataNotFound = 2004,

        #region "RMS"
        Err_Similarity,
        Err_UserExistsForRMCatalogId,
        Err_UserExistsForAccessType,
        Err_DeletePrimaryUser,
        Err_PrimaryUserCannotbeUpdated,
        Err_userIdCanntbeUpdated,
        Err_usernotExist,
        rms_err_invalidrmcatid,
        #endregion

        #region Samir
        Err_HdrNameAlreadyExist = 5000,
        Err_HdrColumnNameAlreadyExist = 5001,
        Err_ForOrganisationValid = 5002,
        Err_TagHeaderDeleteFailed = 5003,
        Err_LabelNameAlreadyExist = 5004,
        Err_TagDisplayDeleteFailed = 5005,
        Err_TeamNameAlreadyExist = 5006,
        Err_ParentTeamNameAlreadyExist = 5007,
        Err_teammanegerNameAlreadyExist = 5008,
        Err_fgSystemOwnerAlreadyExist = 5009,
        Err_fgSystemNameExist = 5010,
        Err_TeamDeadLock = 5011,
        Err_ReportGroupNameAlreadyExist=5012,
        Err_teamUserAlreadyExist=5013,
        Err_NotAuthoriseForReport=5014,
        #endregion

        Err_NoDataFound = 3000,
        Err_SomethingWentWrong = 3001,
        Err_DeadlockArise = 5555,
        Err_AccountAlreadyExist = 1005,
        Err_ParentAccountShouldNotSame = 1006,
        Err_RalAlreadyExist = 4001,
        Err_RalCodeAlreadyExist = 4002,
        Err_InvalidParameter = 4003,
        Err_RptNameAlreadyExist = 4004,
        Err_MaterialGroupAlreadyExist = 4005,
        Err_DocCategoryAlreadyExist = 4006,
        Err_DefaultCannotBeDeleted = 4007,
        Err_DefaultCannotBeUpdated = 4008,
        Err_UnauthorizedAccess = 4009,

    }

    public enum Teamvalidation
    {
        //1:For maneger,2: For other member
        TeamManeger = 1
    }

    public enum FinishGoodSummary
    {
        Dimensions = 1,
        FgSystem = 2,
        FgGlass = 3,
        FGHwBrand = 4,
        RalColor = 5,
        Lamination = 6,
        RatePerSqft = 7,
        RatePerSqmt = 8
    }
}
