using Google.Api.Ads.Common.Lib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Common
{
    public class CommonFunctions
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        IOptions<AppConfig> _config { get; set; }
        public CommonFunctions(IHttpContextAccessor httpContextAccessor, IOptions<AppConfig> config)
        {
            _httpContextAccessor = httpContextAccessor;
            _config = config;
        }
        public async Task<string> UploadFile(IFormFile imgfile)
        {
            string wwwRootPath = Environment.CurrentDirectory;
            string fileName = Path.GetFileNameWithoutExtension(imgfile.FileName);
            string extension = Path.GetExtension(imgfile.FileName);
            fileName = fileName + extension;
            string path = Path.Combine(wwwRootPath + "/Resources/Img/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await imgfile.CopyToAsync(fileStream);
            }

            return path;
        }

        //public async Task<BaseResponse<DocumentConfigurationDto>> GetDocumentConfigurations(ScreenMasterEnum screen)
        //{
        //    string catalogApi = _config.Value.CatalogAPIEndpoint.ToString() + "api/Document/GetDocumentConfiguration?screenId=" + Convert.ToString((int)screen);
        //    Dictionary<string, string> headers = new Dictionary<string, string>();
        //    headers = new Dictionary<string, string>();
        //    headers.Add("Authorization", "Bearer " + _httpContextAccessor.HttpContext.Items[KeyConstant.AccessToken].ToString());
        //    var documentConfiguration = await new Common.Utilities.HttpUtility().GetHttpCallAsync<int, BaseResponse<DocumentConfigurationDto>>(headers, "application/json", catalogApi, (int)screen, "GET");
        //    return documentConfiguration;
        //}

        //public async Task<BaseResponse<string>> GetHierarchialUserIds(long userId)
        //{
        //    string catalogApi = _config.Value.CatalogAPIEndpoint.ToString() + "api/User/GetHierarchialUserIds?userId=" + Convert.ToString(userId);
        //    Dictionary<string, string> headers = new Dictionary<string, string>();
        //    headers = new Dictionary<string, string>();
        //    headers.Add("Authorization", "Bearer " + _httpContextAccessor.HttpContext.Items[KeyConstant.AccessToken].ToString());
        //    var userList = await new Common.Utilities.HttpUtility().GetHttpCallAsync<long, BaseResponse<string>>(headers, "application/json", catalogApi, userId, "GET");
        //    return userList;
        //}
        //public async Task<BaseResponse<List<UserToListDto>>> GetUsersByOrganization(long orgId)
        //{
        //    string catalogApi = _config.Value.CatalogAPIEndpoint.ToString() + "api/User/GetUsersByOrganization?orgId=" + Convert.ToString(orgId);
        //    Dictionary<string, string> headers = new Dictionary<string, string>();
        //    headers = new Dictionary<string, string>();
        //    headers.Add("Authorization", "Bearer " + _httpContextAccessor.HttpContext.Items[KeyConstant.AccessToken].ToString());
        //    var userList = await new Common.Utilities.HttpUtility().GetHttpCallAsync<long, BaseResponse<List<UserToListDto>>>(headers, "application/json", catalogApi, orgId, "GET");
        //    return userList;
        //}
        //public async Task<BaseResponse<UserDetailsDto>> GetUserDetailsByUserId(long userId)
        //{
        //    string catalogApi = _config.Value.CatalogAPIEndpoint.ToString() + "api/User/GetUserDetailsByUserId?userId=" + Convert.ToString(userId);
        //    Dictionary<string, string> headers = new Dictionary<string, string>();
        //    headers = new Dictionary<string, string>();
        //    headers.Add("Authorization", "Bearer " + _httpContextAccessor.HttpContext.Items[KeyConstant.AccessToken].ToString());
        //    var userList = await new Common.Utilities.HttpUtility().GetHttpCallAsync<long, BaseResponse<UserDetailsDto>>(headers, "application/json", catalogApi, userId, "GET");
        //    return userList;
        //}

        public static string GetContentType(string path)
        {
            var provider = new FileExtensionContentTypeProvider();
            string contentType;

            if (!provider.TryGetContentType(path, out contentType))
            {
                contentType = "application/octet-stream";
            }

            return contentType;
        }
    }
}
