using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Entities;

namespace StockMarket.Web.Controllers
{
    public class UserController : Controller
    {

        public List<Company> DisplayChart(List<Color> color)
        {
            //code here to display chart of different companies with different colors

            List<Company> CompanyList = new List<Company>();
            return CompanyList;
        }
        public bool ExportDataFromChart(Chart chart)
        {
            // code here to export data from chart
            return true;
        }

        public List<Company> FilterCompany(string CompanyName, string CompanyCode)
        {
            // code here to filter company based on company name and code

            List<Company> CompanyList = new List<Company>();
            return CompanyList;
        }
       

        public IActionResult GetChart(Company company, string StockExchange, DateTime FromPeriod, DateTime ToPeriod)
        {
            // code here to get chart
            return View();
        }

        public IActionResult SearchCompany(string CompanyName)
        {
            // code here to search for company
            return View();
        }

        public IActionResult UpdateProfile(string UserName)
        {
            // code here to update user profile
            return View();
        }
        public IActionResult GetUserById(int Id)
        {
            // code here to get user by id
            return View();

        }

    }
}



