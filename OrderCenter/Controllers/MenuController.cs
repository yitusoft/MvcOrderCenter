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

            //客户管理{订单管理、客户预购单、量尺信息、更改单管理}、人事管理、合同管理、财务管理

            MenusModel model = new MenusModel();
            model.id = Guid.NewGuid().ToString();
            model.name = "客户管理";
            model.route = "";
            model.icon = "icon-customer";
            model.item = new List<MenusModel>();

            MenusModel modelChildren = new MenusModel();
            modelChildren.id = Guid.NewGuid().ToString();
            modelChildren.name = "订单管理";
            modelChildren.route = "user-List";
            modelChildren.icon = "icon-order";
            model.item.Add(modelChildren);

            modelChildren = new MenusModel();
            modelChildren.id = Guid.NewGuid().ToString();
            modelChildren.name = "客户预购单";
            modelChildren.route = "user-List1";
            modelChildren.icon = "icon-shoppingcar";
            model.item.Add(modelChildren);

            modelChildren = new MenusModel();
            modelChildren.id = Guid.NewGuid().ToString();
            modelChildren.name = "量尺信息";
            modelChildren.route = "user-List2";
            modelChildren.icon = "icon-ruler";
            model.item.Add(modelChildren);

            modelChildren = new MenusModel();
            modelChildren.id = Guid.NewGuid().ToString();
            modelChildren.name = "更改单管理";
            modelChildren.route = "user-List3";
            modelChildren.icon = "icon-update";
            model.item.Add(modelChildren);

            list.Add(model);


            model = new MenusModel();
            model.id = Guid.NewGuid().ToString();
            model.name = "人事管理";
            model.route = "user-List4";
            model.icon = "icon-manpower";
            list.Add(model);

            model = new MenusModel();
            model.id = Guid.NewGuid().ToString();
            model.name = "合同管理";
            model.route = "user-List5";
            model.icon = "icon-contract";
            list.Add(model);

            model = new MenusModel();
            model.id = Guid.NewGuid().ToString();
            model.name = "财务管理";
            model.route = "user-List6";
            model.icon = "icon-finance";
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