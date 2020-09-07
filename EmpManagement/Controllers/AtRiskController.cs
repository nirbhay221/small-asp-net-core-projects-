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
    [Route("atrisk")]
    public class AtRiskController : Controller
    {

        public AppDbContext db;
        public AtRiskController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ViewBag.AtRisk = db.AtRisk.ToList();
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
        public IActionResult Add(AtRisk AtRisk)
        {
            db.AtRisk.Add(AtRisk);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            db.AtRisk.Remove(db.AtRisk.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            return View("Edit", db.AtRisk.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, AtRisk AtRisk)
        {
            db.Entry(AtRisk).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}