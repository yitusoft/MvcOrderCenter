using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderCenter.Models
{
    public class MenusModel
    {
        /// <summary>
        /// Id测试
        /// </summary>
        public string id { get; set; }
        public string upId { get; set; }
        public string name { get; set; }
        public string route { get; set; }
        public List<MenusModel> item { get; set; }
    }
}