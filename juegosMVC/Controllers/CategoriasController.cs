using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using juegosMVC.Models;

namespace juegosMVC.Controllers
{ 
    public class CategoriasController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Categorias/

        public ViewResult Index()
        {
            return View(db.Categorias.ToList());
        }

        //
        // GET: /Categorias/Details/5

        public ViewResult Details(int id)
        {
            Categoria categoria = db.Categorias.Find(id);
            return View(categoria);
        }

        //
        // GET: /Categorias/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Categorias/Create

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(categoria);
        }
        
        //
        // GET: /Categorias/Edit/5
 
        public ActionResult Edit(int id)
        {
            Categoria categoria = db.Categorias.Find(id);
            return View(categoria);
        }

        //
        // POST: /Categorias/Edit/5

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        //
        // GET: /Categorias/Delete/5
 
        public ActionResult Delete(int id)
        {
            Categoria categoria = db.Categorias.Find(id);
            return View(categoria);
        }

        //
        // POST: /Categorias/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Categoria categoria = db.Categorias.Find(id);
            db.Categorias.Remove(categoria);
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