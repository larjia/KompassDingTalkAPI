using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI.Department.Dto
{
    public class DepartmentDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentid")]
        public int PrentId { get; set; }

        [JsonProperty("autoAddUser")]
        public bool AutoAddUser { get; set; }

        [JsonProperty("createDeptGroup")]
        public bool CreateDeptGroup { get; set; }
    }
}
