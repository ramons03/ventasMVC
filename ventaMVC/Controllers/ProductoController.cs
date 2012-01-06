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
    public class ProductoController : Controller
    {
        private Context db = new Context();

        [HttpPost]
        public JsonResult Detalle(int id)
        {
            db.Proveedor.ToList();
            var proveedor = db.Proveedor.Find(id);
            return Json(proveedor);
        }

        //
        // GET: /Producto/

        public ViewResult Index()
        {
            return View(db.Productos.ToList());
        }

        //
        // GET: /Producto/Details/5

        public ViewResult Details(int id)
        {
            Producto producto = db.Productos.Find(id);
            return View(producto);
        }

        //
        // GET: /Producto/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Producto/Create

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(producto);
        }
        
        //
        // GET: /Producto/Edit/5
 
        public ActionResult Edit(int id)
        {
            Producto producto = db.Productos.Find(id);
            return View(producto);
        }

        //
        // POST: /Producto/Edit/5

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        //
        // GET: /Producto/Delete/5
 
        public ActionResult Delete(int id)
        {
            Producto producto = db.Productos.Find(id);
            return View(producto);
        }

        //
        // POST: /Producto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Producto producto = db.Productos.Find(id);
            db.Productos.Remove(producto);
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