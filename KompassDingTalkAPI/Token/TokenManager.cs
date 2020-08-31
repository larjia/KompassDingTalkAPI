using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI.Token
{
    public class TokenManager
    {
        private static string _lastAccessToken;
        private static DateTime _lastAccessTokenTimeOut;

        public async Task<string> GetToken()
        {
            if (!string.IsNullOrEmpty(_lastAccessToken) && DateTime.Now < _lastAccessTokenTimeOut)
            {
                return _lastAccessToken;
            }

            var tokenApi = new TokenApi();
            var result = await tokenApi.GetToken();

            // 缓存Token
            _lastAccessToken = result.AccessToken;
            _lastAccessTokenTimeOut = DateTime.Now.AddSeconds((int)result.ExpiresIn);

            return result.AccessToken;
        }
    }
}
