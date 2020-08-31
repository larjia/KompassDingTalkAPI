using KompassDingTalkAPI.Token.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace KompassDingTalkAPI.Token
{
    public class TokenApi : ApiBase
    {
        public async Task<GetTokenResult> GetTokenAsync()
        {
            var appkey = Config.GetAppKey();
            var appsecret = Config.GetAppSecret();
            return await GetAsync<GetTokenResult>($"gettoken?appkey={appkey}&appsecret={appsecret}");
        }

        public GetTokenResult GetToken()
        {
            var appkey = Config.GetAppKey();
            var appsecret = Config.GetAppSecret();
            return Get<GetTokenResult>($"gettoken?appkey={appkey}&appsecret={appsecret}");
        }
    }
}
