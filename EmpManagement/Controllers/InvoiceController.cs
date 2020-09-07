using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace EmpManagement.Controllers
{
    [Authorize(Roles = "Manager,Technical,Sales")]
    public class InvoiceController : Controller
    {
        public AppDbContext db;
        public InvoiceController(AppDbContext _db )
        {
            db = _db;
        }
        public IActionResult Index()
        {
            List<Project> project = db.Projects.ToList();
            List<Sales> sales = db.Sales.ToList();

            List<ProductSales> ProductSales = db.ProductSales.ToList();
            var MainRecord = from ps in ProductSales
                             join s in sales on ps.Sales_Id equals s.Id into table1
                             from s in table1.ToList()
                             join p in project on ps.Project_Name equals p.Name into table2
                             from p in table2.ToList()
                             select new ViewModel
                             {
                                 ProductSales = ps,
                                 sales = s,
                                 project = p
                             };
            return View(MainRecord);
        }[Route("newindex")]
        public IActionResult NewIndex(){


            return View();
        }
    }
}