using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ventaMVC.Models;

namespace ventaMVC.Controllers
{ 
    public class ProveedorController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Proveedor/

        public ViewResult Index()
        {
            return View(db.Proveedor.ToList());
        }

        //
        // GET: /Proveedor/Details/5

        public ViewResult Details(int id)
        {
            Proveedor proveedor = db.Proveedor.Find(id);
            return View(proveedor);
        }

        //
        // GET: /Proveedor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Proveedor/Create

        [HttpPost]
        public ActionResult Create(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                db.Proveedor.Add(proveedor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(proveedor);
        }
        
        //
        // GET: /Proveedor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Proveedor proveedor = db.Proveedor.Find(id);
            return View(proveedor);
        }

        //
        // POST: /Proveedor/Edit/5

        [HttpPost]
        public ActionResult Edit(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proveedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proveedor);
        }

        //
        // GET: /Proveedor/Delete/5
 
        public ActionResult Delete(int id)
        {
            Proveedor proveedor = db.Proveedor.Find(id);
            return View(proveedor);
        }

        //
        // POST: /Proveedor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Proveedor proveedor = db.Proveedor.Find(id);
            db.Proveedor.Remove(proveedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}