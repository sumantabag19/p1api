using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Common.Utilities
{
    public class TokenClaimsHelper
    {
        public TokenClaimsHelper()
        {
        }

        //public async Task<IMSClaimDetailsDto> GetTokenClaimsList(string headerValue, IHttpContextAccessor _httpContextAccessor)
        //{
        //    IMSClaimDetailsDto details = new IMSClaimDetailsDto();
        //    object claimDetails;
        //    var claims = _httpContextAccessor.HttpContext.Items.TryGetValue(KeyConstant.ImsClaim, out claimDetails);
        //    if (claims)
        //    {
        //        details = claimDetails as IMSClaimDetailsDto;
        //    }
        //    return await Task.FromResult(details);
        //}

        public static string GetImsToken(IEnumerable<string> headerValues)
        {
            var token = string.Empty;
            if (headerValues != null)
            {
                token = headerValues.FirstOrDefault();
                token = token?.Replace("Bearer ", string.Empty);
            }
            return token;
        }
    }
}
