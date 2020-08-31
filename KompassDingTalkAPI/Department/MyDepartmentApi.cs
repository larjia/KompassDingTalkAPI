using GrapeCity.Forguncy.ServerApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI.Department
{
    public class MyDepartmentApi : ForguncyApi
    {
        [Get]
        public void GetAllDepartementList()
        {
            var api = new DepartmentApi();
            var result = api.DepartmentList();

            var json = JsonConvert.SerializeObject(result);
            this.Context.Response.Headers.Append("Access-Control-Allow-Origin", "*");
            this.Context.Response.Write(json);
        }
    }
}
