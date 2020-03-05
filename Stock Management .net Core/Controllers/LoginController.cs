using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Entities;

namespace StockMarket.Web.Controllers
{
    public class LoginController : Controller
    {
        public bool Login(string UserName, string Password, string UserType)
        {
            // code here to login for both user and admin
            return false;
        }

        public bool SignUp(User user)
        {
            // code here for user registration
            return false;
        }
   
    }
}