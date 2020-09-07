using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace EmpManagement.Controllers
{
    [Authorize(Roles = "Manager,Technical,Sales")]
    [Route("sales")]
    public class SalesController : Controller
    {
        public AppDbContext db;
        public SalesController(AppDbContext _db)
        {
            db = _db;
        }
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Sales = db.Sales.ToList();
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Sales Sales)
        {
            db.Sales.Add(Sales);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            db.Sales.Remove(db.Sales.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            return View("Edit", db.Sales.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Sales Sales)
        {
            db.Entry(Sales).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}