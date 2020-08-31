using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI.Token.Dto
{
    public class GetTokenResult : ApiResultBase
    {
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}
