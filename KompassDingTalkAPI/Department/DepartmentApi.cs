﻿using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using GrapeCity.Forguncy.ServerApi;
using KompassDingTalkAPI.Department.Dto;
using KompassDingTalkAPI.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI.Department
{
    public class DepartmentApi : ApiBase
    {
        public async Task<DepartmentResult> DepartmentList(string lang = "zh_CN", bool fetchChild = true, string id = null)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "lang", lang },
                { "fetch_Child", fetchChild.ToString() }
            };
            if (id != null)
            {
                queryParameters.Add("id", id);
            }

            return await Get<DepartmentResult>("department/list?access_token={ACCESS_TOKEN}", queryParameters);
        }
    }
}
