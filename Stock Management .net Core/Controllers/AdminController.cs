using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Entities;

namespace StockMarket.Web.Controllers
{
    public class AdminController : Controller
    {
        public bool AddCompany(List<Company> company)
        {
            // code here to add companies
                return false;
            
        }
        public bool DeleteCompany(int Id)
        {
            //code here to delete particular company
            return true;
        }

        public IActionResult UpdateCompany(int Id)
        {
            //code here to Update a company 
            return View();
        }
       
        public IActionResult GetCompanyById(int Id)
        {
          //code here to get particular comapny
            return View();
        }


        public IActionResult GetIPOById(int Id)
        {
           // code here to get IPO details by id
            return View();
        }


        public bool ImportData(object file)
        {
            //code here to import data
            return true;
        }


        public IActionResult UpdateIPODetail(int Id)
        {
            // code here to update IPO details
            return View();
        }


        public IActionResult ViewCompany(int Id)
        {
           // code here to view company by id
            return View();
        }
    }
}










