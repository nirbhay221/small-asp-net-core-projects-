using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Microsoft.AspNetCore.Authorization;

namespace EmpManagement.Controllers
{
    [Authorize(Roles = "Manager,Technical,Sales")]
    [Route("rentedforproject")]
    public class RentedForProjectController : Controller
    {
        public AppDbContext db;
        public RentedForProjectController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string button)
        {
            List<RentedForProject> RentedForProject = db.RentedForProject.ToList();


            var MainRecord = from rp in RentedForProject
                             select new ViewModel
                             {
                                 RentedForProject = rp
                             };
            return new ViewAsPdf(MainRecord);


        }
        [Route("nextindex")]
        public IActionResult NextIndex()
        {
            return View();
        }

        [Route("findall")]
        public IActionResult FindAllRentedForProject()
        {
            var rentedforproject = db.RentedForProject.Select(i => new
            {
                id = i.Id,
                title = i.Name,
                description = i.Status,
                start = i.RentedFrom.ToString("dd/MM/yyyy"),
                end = i.RentedTo.ToString("dd/MM/yyyy")


            }).ToList();
            return new JsonResult(rentedforproject);
        }
        [Route("nextnextindex")]
        public IActionResult NextNextIndex()
        {
            ViewBag.RentedForProject = db.RentedForProject.ToList();
            return View();
        }
        [Route("nextnextnextnextindex")]
        public IActionResult NextNextNextNextIndex()
        {
            List<RentedForProject> RentedForProject = db.RentedForProject.ToList();


            var MainRecord = from rp in RentedForProject
                             select new ViewModel
                             {
                                 RentedForProject = rp
                             };
            return  View(MainRecord);
        }
        [Route("nextnextnextindex")]
        public IActionResult NextNextNextIndex()
        {
            ViewBag.RentedForProject = db.RentedForProject.ToList();
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
        public IActionResult Add(RentedForProject RentedForProject)
        {
            db.RentedForProject.Add(RentedForProject);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            db.RentedForProject.Remove(db.RentedForProject.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            return View("Edit", db.RentedForProject.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, RentedForProject RentedForProject)
        {
            db.Entry(RentedForProject).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}