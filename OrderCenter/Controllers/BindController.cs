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
        [HttpGet]
        public ApiResult<List<BindListModel>> getRegion()
        {
            List<BindListModel> list = new List<BindListModel>();
            BindListModel model;
            for (int i = 0; i < 5; i++)
            {
                model = new BindListModel();
                model.value = 10 + i;
                model.label = "label" + i;
                model.children = new List<BindListModel>();
                BindListModel m;
                for (int j = 0; j < 5; j++)
                {
                    m = new BindListModel();
                    m.value = 100 + i + j;
                    m.label = "label" + i + j;
                    m.children = new List<BindListModel>();
                    BindListModel mc;
                    for (int k = 0; k < 5; k++)
                    {
                        mc = new BindListModel();
                        mc.label = "label" + i + j + k;
                        mc.value = 1000 + i + j + k;
                        m.children.Add(mc);
                    }
                    model.children.Add(m);
                }
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