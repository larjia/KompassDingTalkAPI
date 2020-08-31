using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI
{
    public class ApiResultBase
    {
        [JsonProperty("errmsg")]
        public string ErrorMessage { get; set; }
        [JsonProperty("errcode")]
        public int ErrorCode { get; set; }
        public bool IsSuccess()
        {
            return ErrorCode == 0;
        }
    }
}
