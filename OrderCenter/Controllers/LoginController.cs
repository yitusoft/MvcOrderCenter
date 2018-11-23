using OrderCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrderCenter.Controllers
{
    public class LoginController : BaseController
    {
        [HttpGet]
        public ApiResult<UserModel> login(string account, string password)
        {
            UserModel model = new UserModel();
            model = _list.Find(x => x.account == account);
            if (model != null)
            {
                _isLogin = true;
            }
            return new ApiResult<UserModel>()
            {
                ReturnCode = 0,
                Message = "",
                Result = model
            };
        }

        [HttpGet]
        public ApiResult<UserModel> updatePassword(string password, string newpPssword)
        {
            UserModel model = new UserModel();
            model = _list.Find(x => x.account == "admin");
            if (model != null)
            {
                _isLogin = false;
            }
            return new ApiResult<UserModel>()
            {
                ReturnCode = 0,
                Message = "",
                Result = model
            };
        }

        [HttpGet]
        public ApiResult<UserModel> unlockLogin(string password)
        {
            UserModel model = new UserModel();
            model = _list.Find(x => x.account == "admin");
            if (model != null)
            {
                _isLogin = true;
            }
            return new ApiResult<UserModel>()
            {
                ReturnCode = 0,
                Message = "",
                Result = model
            };
        }

        [HttpGet]
        public ApiResult<UserModel> checkLogin()
        {
            UserModel model = null;
            if (_isLogin)
            {
                model = _list.Find(x => x.account == "admin");
            }
            return new ApiResult<UserModel>()
            {
                ReturnCode = 0,
                Message = "",
                Result = model
            };
        }

        [HttpGet]
        public ApiResult<int> loginOut()
        {
            _isLogin = false;
            return new ApiResult<int>()
            {
                ReturnCode = 0,
                Message = "",
                Result = 1
            };
        }
    }
}