using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderCenter.Models
{
    public class BaseModel
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public string orderBy { get; set; }
    }
}