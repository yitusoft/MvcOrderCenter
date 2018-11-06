using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderCenter.Models;

namespace OrderCenter.Controllers
{
    public class MenuController : BaseController
    {
        // GET: Menus
        [HttpGet]
        public ApiResult<List<MenusModel>> getMenus()
        {
            List<MenusModel> list = new List<MenusModel>();

            MenusModel model = new MenusModel();
            model.id = Guid.NewGuid().ToString();
            model.name = "用户管理2";
            model.route = "";
            model.item = new List<MenusModel>();
            MenusModel modelChildren = new MenusModel();
            modelChildren.id = Guid.NewGuid().ToString();
            modelChildren.name = "用户列表";
            modelChildren.route = "user-list";
            model.item.Add(modelChildren);
            modelChildren = new MenusModel();
            modelChildren.id = Guid.NewGuid().ToString();
            modelChildren.name = "用户新增";
            modelChildren.route = "user-edit";
            model.item.Add(modelChildren);
            list.Add(model);
            model = new MenusModel();
            modelChildren = new MenusModel();
            model.id = Guid.NewGuid().ToString();
            model.name = "权限管理";
            model.route = "";
            model.item = new List<MenusModel>();
            modelChildren.id = Guid.NewGuid().ToString();
            modelChildren.name = "权限列表";
            modelChildren.route = "role-list";
            model.item.Add(modelChildren);
            list.Add(model);
            return new ApiResult<List<MenusModel>>()
            {
                ReturnCode = 0,
                Message = "",
                Result = list
            };
        }
    }
}