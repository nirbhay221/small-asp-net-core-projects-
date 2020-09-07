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
    public class ProductsController : Controller
    {
        protected AppDbContext db;

        public ProductsController(AppDbContext _db)
        {
            db = _db;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
            }

            Product Product = db.Products.Single(m => m.Id == id);
            if (Product == null)
            {
            }

            return View(Product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product Product)
        {
            Product.Name = (Product.Name ?? "").Trim();
            if (string.IsNullOrEmpty(Product.Name))
            {
                ModelState.AddModelError("", "Nazwa nie może być pusta!");
            }

            if (ModelState.IsValid)
            {
                if (!db.Products.Any(igr => igr.Name == Product.Name))
                {
                    Product.Id = Guid.NewGuid();
                    db.Products.Add(Product);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Taki składnik już istnieje!");
                }

            }
            return View(Product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
            }

            Product Product = db.Products.Single(m => m.Id == id);
            if (Product == null)
            {
            }
            return View(Product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product Product)
        {
            if (db.Products.Any(igr => igr.Name == Product.Name))
            {
                ModelState.AddModelError("", "Taki składnik już istnieje!"); ;
            }

            Product.Name = (Product.Name ?? "").Trim();
            if (string.IsNullOrEmpty(Product.Name))
            {
                ModelState.AddModelError("", "Nazwa nie może być pusta!");
            }

            if (ModelState.IsValid)
            {
                db.Update(Product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(Product);
        }

        // GET: Products/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(Guid? id, string error = "")
        {
            if (id == null)
            {
            }

            Product Product = db.Products.Single(m => m.Id == id);
            if (Product == null)
            {
            }

            if (error != "")
            {
                ViewBag.Error = "Składnik używany przez co najmniej jedną pizzę!";
            }
            return View(Product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (db.ProjectProducts.Any(pi => pi.ProductId == id))
            {
                return RedirectToAction("Delete", new { id = id, error = "yes" });
            }

            var Product = db.Products.Single(m => m.Id == id);
            db.Products.Remove(Product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}