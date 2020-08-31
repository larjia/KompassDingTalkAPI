using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KompassDingTalkAPI.Token;
using Newtonsoft.Json;
using RestSharp;

namespace KompassDingTalkAPI
{
    public abstract class ApiBase
    {
        private const string AccessTokenString = "{ACCESS_TOKEN}";
        private const string BaseApiUrl = "https://oapi.dingtalk.com/";

        protected virtual async Task<T> Get<T>(string resourceUrl, Dictionary<string, string> queryParameters = null)
            where T : ApiResultBase, new()
        {
            resourceUrl = await SetAccessToken(resourceUrl);
            var client = new RestClient(BaseApiUrl);
            var request = new RestRequest(resourceUrl, Method.GET);
            request.AddHeader("cache-control", "no-cache");
            if (queryParameters != null && queryParameters.Count > 0)
            {
                foreach (var par in queryParameters)
                {
                    request.AddQueryParameter(par.Key, par.Value, true);
                }
            }
            return await ReturnDataAsync<T>(client, request);
        }

        protected virtual async Task<T> Post<T>(string resourceUrl, object data = null) where T : ApiResultBase, new()
        {
            resourceUrl = await SetAccessToken(resourceUrl);
            var client = new RestClient(BaseApiUrl);
            var request = new RestRequest(resourceUrl, Method.POST);
            request.AddHeader("cache-control", "no-cache");
            if (data != null)
            {
                request.AddJsonBody(data);
            }

            return await ReturnDataAsync<T>(client, request);
        }

        private async Task<string> SetAccessToken(string url)
        {
            if (url.IndexOf(AccessTokenString, StringComparison.CurrentCultureIgnoreCase) == -1)
            {
                return url;
            }

            var tokenManager = new TokenManager();
            var token = await tokenManager.GetToken();
            url = url.Replace(AccessTokenString, token, StringComparison.CurrentCultureIgnoreCase);
            return url;
        }

        private async Task<T> ReturnDataAsync<T>(RestClient client, RestRequest request) where T : ApiResultBase, new()
        {
            var response = await client.ExecuteAsync(request);
            var data = JsonConvert.DeserializeObject<T>(response.Content);
            return data;
        }
    }
}
