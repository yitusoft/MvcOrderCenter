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
                model.createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                model.id = Guid.NewGuid().ToString();
                model.status = m.status;
                model.type = m.type;
                _list.Add(model);
            }
            else
            {
                model = _list.Find(x => x.id == m.id);
                model.account = m.account;
                model.address = m.address;
                model.age = m.age;
                model.name = m.name;
                model.createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                model.status = m.status;
                model.type = m.type;
            }
            return new ApiResult<int>()
            {
                ReturnCode = 0,
                Message = "",
                Result = 1
            };

        }
        [HttpGet]
        public ApiResult<int> delete(string id)
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

        [HttpPost]
        public ApiResult<List<UserModel>> getList(UserModel m)
        {
            List<UserModel> list = new List<UserModel>();
            int total = _list.Count;
            list = _list.Where(a => a.account == m.account || string.IsNullOrWhiteSpace(m.account)).ToList();
            if (!string.IsNullOrWhiteSpace(m.account))
            {
                total = list.Count;
            }
            switch (m.orderBy.ToLower().Trim())
            {
                case "account":
                    list = (from s in list orderby s.account select s).ToList();

                    break;
                case "account desc":
                    list = (from s in list orderby s.account descending select s).ToList();
                    break;
                case "age":
                    list = (from s in list orderby s.age select s).ToList();

                    break;
                case "age desc":
                    list = (from s in list orderby s.age descending select s).ToList();
                    break;
            }
            list = list.Skip((m.pageIndex - 1) * m.pageSize).Take(m.pageSize).ToList();

            return new ApiResult<List<UserModel>>()
            {
                ReturnCode = 0,
                Total = total,
                Result = list
            };
        }

    }
}