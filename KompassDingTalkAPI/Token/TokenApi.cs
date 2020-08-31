using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using KompassDingTalkAPI.Token.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI.Token
{
    public class TokenApi : ApiBase
    {
        private static string _lastAccessToken;
        private static DateTime _lastAccessTokenTimeOut;

        //private static GetTokenResult _lastAccessToken;

        public async Task<GetTokenResult> GetToken()
        {
            var appkey = Config.GetAppKey();
            var appsecret = Config.GetAppSecret();
            return await Get<GetTokenResult>($"gettoken?appkey={appkey}&appsecret={appsecret}");
        }

        //public static string GetAccessToken(string appkey, string appsecret)
        //{
        //    if (!string.IsNullOrEmpty(_lastAccessToken) && DateTime.Now < _lastAccessTokenTimeOut)
        //    {
        //        return _lastAccessToken;
        //    }

        //    try
        //    {
        //        IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
        //        OapiGettokenRequest req = new OapiGettokenRequest();
        //        req.SetHttpMethod("GET");
        //        req.Appkey = appkey;
        //        req.Appsecret = appsecret;
        //        OapiGettokenResponse rsp = client.Execute(req);

        //        // 缓存token
        //        _lastAccessToken = rsp.AccessToken;
        //        _lastAccessTokenTimeOut = DateTime.Now.AddSeconds((int)rsp.ExpiresIn);

        //        return rsp.AccessToken;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
    }
}
