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
    [Route("client")]
    public class ClientController : Controller
    {
        public AppDbContext db;
        public ClientController(AppDbContext _db)
        {
            db = _db;
        }
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Client = db.Client.ToList();
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
        public IActionResult Add(Client Client)
        {
            db.Client.Add(Client);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            db.Client.Remove(db.Client.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            return View("Edit", db.Client.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Client Client)
        {
            db.Entry(Client).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}