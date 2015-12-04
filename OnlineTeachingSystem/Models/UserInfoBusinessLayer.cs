﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineTeachingSystem.DataAccessLayer;
using System.Web.Mvc;

namespace OnlineTeachingSystem.Models
{
    public class UserInfoBusinessLayer
    {
        public UserInfo SignUp(UserInfo userInfo)
        {
            OTSDBDAL otsdbDAL = new OTSDBDAL();
            otsdbDAL.UserInfoList.Add(userInfo);
            otsdbDAL.SaveChanges();
            return userInfo;
        }
        public List<UserInfo> GetUserInfoList()
        {
            OTSDBDAL otsdbDAL = new OTSDBDAL();
            return otsdbDAL.UserInfoList.ToList();
        }
        public UserInfo Remove(UserInfo userInfo)
        {
            OTSDBDAL otsdbDAL = new OTSDBDAL();
            otsdbDAL.UserInfoList.Remove(userInfo);
            otsdbDAL.SaveChanges();
            return userInfo;
        }
        public UserInfo Add(UserInfo userInfo)
        {
            OTSDBDAL otsdbDAL = new OTSDBDAL();
            otsdbDAL.UserInfoList.Add(userInfo);
            otsdbDAL.SaveChanges();
            return userInfo;
        }
    }
}