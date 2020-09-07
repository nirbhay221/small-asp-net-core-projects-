using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagement.Controllers
{
    [Authorize(Roles = "Manager,Technical,Sales")]
    [Route("complete")]
    public class CompleteController : Controller
    {
        public AppDbContext db;
        public CompleteController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ViewBag.Complete = db.Complete.ToList();
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
        public IActionResult Add(Complete Complete)
        {
            db.Complete.Add(Complete);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            db.Complete.Remove(db.Complete.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            return View("Edit", db.Complete.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id,Complete Complete)
        {
            db.Entry(Complete).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}