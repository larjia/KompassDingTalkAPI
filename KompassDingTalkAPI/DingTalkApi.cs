using GrapeCity.Forguncy.ServerApi;
using KompassDingTalkAPI.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI
{
    public class DingTalkApi : ForguncyApi
    {
        [Get]
        public async void GetDepartmentList()
        {
            var deptApi = new DepartmentApi();
            var result = await deptApi.DepartmentList();
        }
    }
}
