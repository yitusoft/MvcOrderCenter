using OrderCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderCenter.Controllers
{
    public class BindController : BaseController
    {
        [HttpGet]
        public ApiResult<List<BindListModel>> getList()
        {
            List<BindListModel> list = new List<BindListModel>();
            BindListModel model;
            for (int i = 0; i < 10; i++)
            {
                model = new BindListModel();
                model.id = i;
                model.value = 10 + i;
                model.key = "key" + i;
                model.text = "text" + i;
                list.Add(model);
            }
            return new ApiResult<List<BindListModel>>()
            {
                ReturnCode = 0,
                Message = "",
                Result = list
            };
        }
    }
}