using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderCenter.Models
{
    public class UserModel : BaseModel
    {
        public string id { get; set; }
        public string account { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string createDate { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
    }
}