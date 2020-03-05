using NSubstitute;
using StockMarket.BusinessLayer.Services;
using StockMarket.DataLayer.NHibernateConfigurations;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StockMarket.Tests.TestCases
{
   public class BoundaryTest
    {
        private readonly UserServices _service;
        private readonly LoginServices _Loginservice;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();


        public BoundaryTest()
        {
            _service = new UserServices(_session);
            _Loginservice = new LoginServices(_session);
        }
        [Fact]
        public void BoundaryTestForPassword()
        {
            User user = new User { Id = 10, UserName = "john", PassWord = "1234567890", UserType = "1", Email = "jphn@gmail.com", MobileNumber = 9923568547 };
            var MaxLenghthRequired = 10;

            //Action
            var actualLenghth = user.PassWord.Length;

            //Assert
            Assert.Equal(MaxLenghthRequired, actualLenghth);

        }

        [Fact]
        public void BoundaryTest_ForuserPassword_Length()
        {
            User user = new User
            {
                PassWord = "1234567"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.PassWord.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ValidMobileNumber()
        {
            User user = new User
            {
                MobileNumber = 1234567
            };
            //Action
            var BuyerMobileNumber = user.MobileNumber.ToString();

            //Assert
            Assert.Equal(10, BuyerMobileNumber.Length);
        }

        [Fact]
        public void BoundaryTestForUsername()
        {
            User user = new User { UserName = "userabc" };
            var MinLength = 8;
            var MaxLength = 12;

            //Action
            var ActualLength = user.UserName.Length;

            //Assert
            Assert.InRange(ActualLength, MinLength, MaxLength);
        }

    }
}
