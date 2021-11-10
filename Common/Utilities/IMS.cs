using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestApplication.Common.Utilities
{
    public class IMS
    {
        #region Http call Generic Function 
        /// <summary>
        /// Generic function to http call
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Model"></param>
        /// <param name="header"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<TOutPut> GetHttpCallAsync<T, TOutPut>(string header, string url, T model, string type)
        {
            string content = string.Empty;
            try
            {
                using (var httpClient = new HttpClient()) // http clinet call 
                {
                    string token = header; token = token?.Replace("Bearer ", string.Empty);
                    httpClient.DefaultRequestHeaders.Add("Authorization", token);
                   // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header.Replace("Bearer", "").Trim());
                    httpClient.DefaultRequestHeaders.Add("appName","JEM");
                    HttpResponseMessage response = null;
                    string json = string.Empty;
                    StringContent httpContent;

                    switch (type)
                    {
                        case "GET":
                            response = await httpClient.GetAsync(url); // call the api 
                            break;

                        case "POST":

                            // Prepare Json object
                            json = JsonConvert.SerializeObject(model, Formatting.Indented);
                            httpContent = new StringContent(json.ToString(), Encoding.UTF8, "application/json"); // create model of type http content

                            response = httpClient.PostAsync(url, httpContent).Result; // call Insert the api
                            break;

                        case "PUT":

                            // Prepare Json object
                            json = JsonConvert.SerializeObject(model, Formatting.Indented);
                            httpContent = new StringContent(json.ToString(), Encoding.UTF8, "application/json"); // create model of type http content

                            response = httpClient.PutAsync(url, httpContent).Result; // call update the api
                            break;

                        case "PATCH":
                            break;

                        case "DELETE":

                            response = httpClient.DeleteAsync(url).Result; // call the delete api 
                            break;
                    }

                    if (response != null && response.IsSuccessStatusCode) // check response status
                    {
                        using (Stream responseStream = response.Content.ReadAsStreamAsync().Result)
                        {
                            content = new StreamReader(responseStream).ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error
            }
            var finalcontent=JsonConvert.SerializeObject(content);
            return JsonConvert.DeserializeObject<TOutPut>(finalcontent); // deserialize the object
        }
        #endregion



        public async Task<ApiResponseMsgModel> ImsDeleteAllUsersByOrgId(string IMSSecurityAPIEndpoint, string token, string orgName)
        {
            ApiResponseMsgModel objApiResponseMsg = new ApiResponseMsgModel();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var result = await client.DeleteAsync(IMSSecurityAPIEndpoint + "/api/org/DeleteAllUsersByOrgId?orgId=" + orgName);

                var contents = await result.Content.ReadAsStringAsync();
                objApiResponseMsg.StatusCode = result.StatusCode;
                objApiResponseMsg.Message = contents;
                return objApiResponseMsg;
            }
        }

        public async Task<ApiResponseMsgModel> ImsDeleteOrganizationByOrgId(string IMSSecurityAPIEndpoint, string token, string orgName)
        {
            ApiResponseMsgModel objApiResponseMsg = new ApiResponseMsgModel();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var result =
                    await client.DeleteAsync(IMSSecurityAPIEndpoint + "/api/org/DeleteOrganization?orgId=" + orgName);

                var contents = await result.Content.ReadAsStringAsync();
                objApiResponseMsg.StatusCode = result.StatusCode;
                objApiResponseMsg.Message = contents;
                return objApiResponseMsg;
            }
        }

    }
    public class ImsOrg
    {
        //public string OrgId { get; set; }
        public string OrgName { get; set; }
        public bool isActive { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string TenantDB { get; set; }
    }
    public class ApiResponseMsgModel
    {
        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }
        public Guid UsId { get; set; }
    }
}
