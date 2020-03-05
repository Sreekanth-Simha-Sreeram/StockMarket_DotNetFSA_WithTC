using StockMarket.BusinessLayer.Interfaces;
using StockMarket.DataLayer.NHibernateConfigurations;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.BusinessLayer.Services
{
    public class LoginServices : ILoginServices
    {

        private readonly IMapperSession _session;

        public LoginServices(IMapperSession session)
        {
            _session = session;
        }
        public bool Login(string UserName, string Password, string UserType)
        {
            return false;
        }

        public bool SignUp(User user)
        {
            return false;
        }
    }
}
