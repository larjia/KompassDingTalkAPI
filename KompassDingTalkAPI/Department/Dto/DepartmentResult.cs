using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI.Department.Dto
{
    public class DepartmentResult : ApiResultBase
    {
        public List<DepartmentDto> Department { get; set; }
    }
}
