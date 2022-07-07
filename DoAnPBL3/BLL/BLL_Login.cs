﻿using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    class BLL_Login
    {
        private static BLL_Login _Instance;
        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_Login()
        {

        }

        public string CheckLogin(Account account)
        {
            if (account.Username.Trim() == "" && account.Password.Trim() == "")
                return "Vui lòng nhập tên tài khoản và mật khẩu";
            else if (account.Username.Trim() == "")
                return "Vui lòng nhập tên tài khoản";
            else if (account.Password.Trim() == "")
                return "Vui lòng nhập mật khẩu";
            else
            {
                string mgs = DAL_Login.Instance.CheckLogin(account);
                return mgs;
            }
        }

        public string GetNameStaff(Account account)
        {
            return DAL_Login.Instance.GetNameStaff(account);
        }
    }
}
