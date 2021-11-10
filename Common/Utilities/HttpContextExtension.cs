
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace TestApplication.Common.Utilities
{
    public class HttpContextExtension
    {
        /// <summary>
        /// Get IMSClaim details
        /// </summary>
        /// <param name="httpContextAccessor"></param>
        /// <returns></returns>
        //public async Task<IMSClaimDetailsDto> GetIMSClaimDetail(IHttpContextAccessor httpContextAccessor)
        //{
        //    IMSClaimDetailsDto details = new IMSClaimDetailsDto();
        //    Microsoft.Extensions.Primitives.StringValues headerValue = new Microsoft.Extensions.Primitives.StringValues();
        //    var valueExists = httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out headerValue);
        //    if (valueExists)
        //    {
        //        object claimDetails;
        //        var claims = httpContextAccessor.HttpContext.Items.TryGetValue(KeyConstant.ImsClaim, out claimDetails);

        //        if (claims)
        //        {
        //            details = claimDetails as IMSClaimDetailsDto;
        //        }
        //    }

        //    return await Task.FromResult(details);
        //}

        /// <summary>
        /// Get token Values
        /// </summary>
        /// <param name="headerValue"></param>
        /// <returns></returns>
        //public IMSClaimDetailsDto GetTokenClaimsLists(IHttpContextAccessor httpContextAccessor, IOptions<AppConfig> appSetting)
        //{
        //    IMSClaimDetailsDto details = new IMSClaimDetailsDto();
        //    object claimDetails;
        //    var claims = httpContextAccessor.HttpContext.Items.TryGetValue(KeyConstant.ImsClaim, out claimDetails);
        //    if (claims)
        //    {
        //        details = claimDetails as IMSClaimDetailsDto;
        //    }
        //    return details;
        //}
    }
}
