using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Configuration;
using OrderCenter.Models;
using System.Web.Http;

namespace OrderCenter.Controllers
{
    public class FileUploadController : BaseController
    {
        [HttpPost]
        public ApiResult<fileModel> upload()
        {
            fileModel model = new fileModel();
            var file = HttpContext.Current.Request.Files[0];
            string type = HttpContext.Current.Request.Form["type"];
            string filename = file.FileName;
            string SavePath = ConfigurationManager.AppSettings["filepath"].TrimEnd("/".ToCharArray()) + "/" + type;

            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
            string fileExt = filename.Substring(filename.LastIndexOf('.'));
            string name = DateTime.Now.ToString("yyyyMMddHHmmssffff") + fileExt;
            string path = type + "/" + name;
            string fullPathUrl = Path.Combine(SavePath, name);
            file.SaveAs(fullPathUrl);
            model.downurl = "";
            model.name = filename;
            model.url = path;
            model.path = path;
            model.newname = name;
            model.size = file.ContentLength / 1024;
            return new ApiResult<fileModel>()
            {
                ReturnCode = 0,
                Message = "",
                Result = model
            };
        }
        [HttpPost]
        public ApiResult<int> uploads()
        {
            return new ApiResult<int>()
            {
                ReturnCode = 0,
                Message = "",
                Result = 1
            };
        }
    }
}