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
   public class FunctionalTest
    {
        private readonly AdminServices _Adminservice;
        private readonly UserServices _Userservice;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();


        public FunctionalTest()
        {
            _Adminservice = new AdminServices(_session);
            _Userservice = new UserServices(_session);
        }

        // bool AddCompany(Company company);
        [Fact]
        public void TestFor_AddCompany()
        {

            Company company = new Company()
            {
                Id = 1,
                CompanyName = "Mobile",
                CEO = "2",
                BoardDirectors = "400",
                TurnOver = 2,
                CompanyStockCode = "2"


            };

            List<Company> itemlist = new List<Company>();
            itemlist.Add(company);

            //Action
            var IsAdded = _Adminservice.AddCompany(itemlist);

            //Assert
            Assert.True(IsAdded);

        }


        [Fact]
        public void TestFor_DeleteCompany()
        {
            //Arrange
            Company company = new Company();
            var id = company.Id;

            //Action
            var isDeleted = _Adminservice.DeleteCompany(id);

            //Assert
            Assert.True(isDeleted);
        }


        [Fact]
        public void TestFor_UpdateCompany()
        {
            //Company EditCompany(int Id)
            Company company = new Company();
            var id = company.Id;


            //Action
            Company editedcompany = _Adminservice.UpdateCompany(id);
            Company editsCompany = _Adminservice.GetCompanyById(id);


            //Assert
            Assert.Equal(editsCompany, editedcompany);


        }


        [Fact]
        public void TestFor_EditIPODetails()
        {
            //Company EditCompany(int Id)
            IPODetail ipoDetails = new IPODetail() { Id = 11, CompanyName = "MS" };
            var id = ipoDetails.Id;

            //Action
            IPODetail editedIPODetails = _Adminservice.UpdateIPODetail(id);
            IPODetail editedIpoFromDb = _Adminservice.GetIPOById(id);

            //Assert
            Assert.Equal(editedIpoFromDb, editedIPODetails);
        }


        [Fact]
        public void TestFor_ViewTasksForUserTest()
        {
            Company company = new Company()
            {
                Id = 1,
                CompanyName = "Mobile",
                CEO = "2",
                BoardDirectors = "400",
                TurnOver = 2,
                CompanyStockCode = "2"
            };

            //Action
            var viewedCompany = _Adminservice.ViewCompany(company.Id);

            //Assert
            Assert.Equal(company.Id, viewedCompany.Id);
        }

        //User Test scripts

       
        [Fact]
        public void TestFor_SearchCompany()
        {

            //Arrange
            Company company = new Company() { CompanyName = "MS" };


            //Action
            Company companydetails = _Userservice.SearchCompany(company.CompanyName);

            //Assert
            Assert.Equal(company, companydetails);
        }


        [Fact]
        public void TestFor_UpdateProfile()
        {
            //Arrange
            User user = new User { Id = 10, UserName = "john", PassWord = "1234", UserType = "1", Email = "jphn@gmail.com", MobileNumber = 9923568547 };

            //Action
            var updtedUser = _Userservice.UpdateProfile(user.UserName);
            var DbUpdatedUser = _Userservice.GetUserById(user.Id);
            //Assert
            Assert.Equal(DbUpdatedUser, updtedUser);

        }



    }
}
