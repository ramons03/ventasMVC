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
    public class JuegosController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Juegos/

        public ViewResult Index()
        {
            return View(db.Juegos.ToList());
        }

        //
        // GET: /Juegos/Details/5

        public ViewResult Details(int id)
        {
            Juego juego = db.Juegos.Find(id);
            return View(juego);
        }

        //
        // GET: /Juegos/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Juegos/Create

        [HttpPost]
        public ActionResult Create(Juego juego)
        {
            if (ModelState.IsValid)
            {
                db.Juegos.Add(juego);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(juego);
        }
        
        //
        // GET: /Juegos/Edit/5
 
        public ActionResult Edit(int id)
        {
            Juego juego = db.Juegos.Find(id);
            return View(juego);
        }

        //
        // POST: /Juegos/Edit/5

        [HttpPost]
        public ActionResult Edit(Juego juego)
        {
            if (ModelState.IsValid)
            {
                db.Entry(juego).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(juego);
        }

        //
        // GET: /Juegos/Delete/5
 
        public ActionResult Delete(int id)
        {
            Juego juego = db.Juegos.Find(id);
            return View(juego);
        }

        //
        // POST: /Juegos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Juego juego = db.Juegos.Find(id);
            db.Juegos.Remove(juego);
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