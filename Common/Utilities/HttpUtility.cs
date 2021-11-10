using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Common.Utilities
{
    public class HttpUtility
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
        public async Task<TOutPut> GetHttpCallAsync<T, TOutPut>(Dictionary<string, string> headers, string contentType, string url, T model, string type)
        {
            string content = string.Empty;
            try
            {
                using (var httpClient = new HttpClient()) // http clinet call 
                {
                    foreach (var item in headers)
                    {
                        httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }

                    httpClient.DefaultRequestHeaders.Add("appName", "EVA");

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
                            json = contentType == "application/json"
                                ? JsonConvert.SerializeObject(model, Formatting.Indented)
                                : "grant_type=client_credentials&scope=read write serviceapi_all";
                            httpContent = new StringContent(json.ToString(), Encoding.UTF8, contentType); // create model of type http content

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
                    else
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
            var finalcontent = JsonConvert.SerializeObject(content);
            return JsonConvert.DeserializeObject<TOutPut>(content); // deserialize the object
        }
        #endregion
    }

    public class AccessTokenResponse
    {
        public string Scope { get; set; }
        public string Token_type { get; set; }
        public string Access_token { get; set; }
        //public string expires_in { get; set; }
        public string Refresh_token { get; set; }
    }

}
