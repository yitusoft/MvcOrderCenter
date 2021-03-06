﻿using OrderCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrderCenter.Controllers
{
    public class BaseController : ApiController
    {
        protected static List<UserModel> _list = new List<UserModel>
        {
            new UserModel {account = "admin", address = "成都市", age = 30, id = Guid.NewGuid().ToString(), name = "超级管理员", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0001", address = "成都市1", age = 23, id = Guid.NewGuid().ToString(), name = "管理员1", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0002", address = "成都市2", age = 44, id = Guid.NewGuid().ToString(), name = "管理员2", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0003", address = "成都市3", age = 21, id = Guid.NewGuid().ToString(), name = "管理员3", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0004", address = "成都市4", age = 11, id = Guid.NewGuid().ToString(), name = "管理员4", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0001", address = "成都市1", age = 23, id = Guid.NewGuid().ToString(), name = "管理员1", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0002", address = "成都市2", age = 44, id = Guid.NewGuid().ToString(), name = "管理员2", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0003", address = "成都市3", age = 21, id = Guid.NewGuid().ToString(), name = "管理员3", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0004", address = "成都市4", age = 11, id = Guid.NewGuid().ToString(), name = "管理员4", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0001", address = "成都市1", age = 23, id = Guid.NewGuid().ToString(), name = "管理员1", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0002", address = "成都市2", age = 44, id = Guid.NewGuid().ToString(), name = "管理员2", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0003", address = "成都市3", age = 21, id = Guid.NewGuid().ToString(), name = "管理员3", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0004", address = "成都市4", age = 11, id = Guid.NewGuid().ToString(), name = "管理员4", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0001", address = "成都市1", age = 23, id = Guid.NewGuid().ToString(), name = "管理员1", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0002", address = "成都市2", age = 44, id = Guid.NewGuid().ToString(), name = "管理员2", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0003", address = "成都市3", age = 21, id = Guid.NewGuid().ToString(), name = "管理员3", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0004", address = "成都市4", age = 11, id = Guid.NewGuid().ToString(), name = "管理员4", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0001", address = "成都市1", age = 23, id = Guid.NewGuid().ToString(), name = "管理员1", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0002", address = "成都市2", age = 44, id = Guid.NewGuid().ToString(), name = "管理员2", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0003", address = "成都市3", age = 21, id = Guid.NewGuid().ToString(), name = "管理员3", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0004", address = "成都市4", age = 11, id = Guid.NewGuid().ToString(), name = "管理员4", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0001", address = "成都市1", age = 23, id = Guid.NewGuid().ToString(), name = "管理员1", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0002", address = "成都市2", age = 44, id = Guid.NewGuid().ToString(), name = "管理员2", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0003", address = "成都市3", age = 21, id = Guid.NewGuid().ToString(), name = "管理员3", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0004", address = "成都市4", age = 11, id = Guid.NewGuid().ToString(), name = "管理员4", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0001", address = "成都市1", age = 23, id = Guid.NewGuid().ToString(), name = "管理员1", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0002", address = "成都市2", age = 44, id = Guid.NewGuid().ToString(), name = "管理员2", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0003", address = "成都市3", age = 21, id = Guid.NewGuid().ToString(), name = "管理员3", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""},
            new UserModel {account = "admin0004", address = "成都市4", age = 11, id = Guid.NewGuid().ToString(), name = "管理员4", createDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),status = true, type = ""}
        };

        protected static bool _isLogin = false;
    }
}