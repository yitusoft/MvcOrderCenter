using OrderCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrderCenter.Controllers
{
    public class UserController : BaseController
    {
        [HttpPost]
        public ApiResult<int> operation([FromBody] UserModel m)
        {
            UserModel model = new UserModel();
            if (string.IsNullOrWhiteSpace(m.id))
            {
                model.account = m.account;
                model.address = m.address;
                model.age = m.age;
                model.name = m.name;
                model.createDate = DateTime.Now;
                model.id = Guid.NewGuid().ToString();
                model.status = m.status;
                model.types = m.types;
                _list.Add(model);
            }
            else
            {
                model = _list.Find(x => x.id == m.id);
                model.account = m.account;
                model.address = m.address;
                model.age = m.age;
                model.name = m.name;
                model.createDate = DateTime.Now;
                model.status = m.status;
                model.types = m.types;
            }
            return new ApiResult<int>()
            {
                ReturnCode = 0,
                Message = "",
                Result = 1
            };

        }
        [HttpPost]
        public ApiResult<int> delete([FromBody] string id)
        {
            _list.RemoveAll(x => x.id == id);
            return new ApiResult<int>()
            {
                ReturnCode = 0,
                Message = "",
                Result = 1
            };

        }
        [HttpGet]
        public ApiResult<UserModel> getModel(string id)
        {
            UserModel model = new UserModel();
            model = _list.Find(x => x.id == id);
            return new ApiResult<UserModel>()
            {
                ReturnCode = 0,
                Message = "",
                Result = model
            };
        }

        [HttpGet]
        public ApiResult<List<UserModel>> getList()
        {
            List<UserModel> list = new List<UserModel>();
            list = _list;

            return new ApiResult<List<UserModel>>()
            {
                ReturnCode = 0,
                Message = "",
                Result = list
            };
        }

        [HttpGet]
        public ApiResult<List<UserModel>> getList(int pageIndex, int pageSize)
        {
            List<UserModel> list = new List<UserModel>();
            list = _list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            int total = _list.Count;
            return new ApiResult<List<UserModel>>()
            {
                ReturnCode = 0,
                Total = total,
                Result = list
            };
        }

    }
}