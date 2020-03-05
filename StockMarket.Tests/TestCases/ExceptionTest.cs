using NSubstitute;
using StockMarket.BusinessLayer.Services;
using StockMarket.DataLayer.NHibernateConfigurations;
using StockMarket.Entities;
using StockMarket.Tests.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StockMarket.Tests.TestCases
{
    public class ExceptionTest
    {
        private readonly UserServices _service;
        private readonly AdminServices _Adminservice;
        private readonly LoginServices _Loginservice;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();


        public ExceptionTest()
        {
            _service = new UserServices(_session);
            _Adminservice = new AdminServices(_session);
            _Loginservice = new LoginServices(_session);
        
    }

        [Fact]
        public void ExceptionTestForCompanyNotFound()
        {

            //Arrange
            Company company = new Company()
            {
                Id = 1,
                CompanyName = "Mobile",
                CEO = "2",
                BoardDirectors = "400",
                TurnOver = 2,
                CompanyStockCode = "2"
            };
            User user = new User { Id = 10, UserName = "john", PassWord = "1234", UserType = "1", Email = "jphn@gmail.com", MobileNumber = 9923568547 };

            var SerchedCompoany = _service.SearchCompany("IBM");
            var DbUpdatedUser = _service.GetUserById(user.Id);


            //Assert
            var ex = Assert.Throws<CompanyNotFoundException>(() => _service.SearchCompany("IBM"));
            Assert.Equal("Company Not Found in Tasks List", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_InvalidImportDataFormat()
        {
           
          //Action
        
            var ex = Assert.Throws<ImportDataFormat>(() => _Adminservice.ImportData(""));
            //Assert
            Assert.Equal("Need to be in Excel format", ex.Messages);

         }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
            User user = new User
            {
                UserName = "abc",
                PassWord = "123",
                UserType = "user"

            };
            //Assert
            var ex = Assert.Throws<InvalidCredentialsException>(() => _Loginservice.Login(user.UserName,user.PassWord,user.UserType));

            Assert.Equal("Please enter valid usename & password", ex.Messages);


        }
        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {

            User user = new User
            {
                UserName = "abc",
                PassWord = "123",
                UserType = "user"

            };
            //Action

            var ex = Assert.Throws<InvalidCredentialsException>(() => _Loginservice.Login(user.UserName, user.PassWord, user.UserType));
            //Assert
            Assert.Equal("Please enter valid usename & password", ex.Messages);

        }


    }
}
