using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class VerhuisdozenController : Controller
    {

        List<Verhuisdoos> VerhuisdozenLijst = new List<Verhuisdoos>();

        Verhuisdoos verhuisdoos = new Verhuisdoos()
        {
            VerhuisdoosNaam = "Lege doos",
            VerhuisdoosOmschrijving = "Doos nog te vullen",
            VerhuisitemLijst = null
        };

        Verhuisitem verhuisitem = new Verhuisitem();
        

        // GET: Verhuisdozen
        public ActionResult Index()
        {
            var alleVerhuisdozen = VerhuisdozenLijst.ToList();
            return View(alleVerhuisdozen);
        }

        // GET: Verhuisdozen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Verhuisdozen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Verhuisdozen/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Verhuisdozen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Verhuisdozen/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Verhuisdozen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Verhuisdozen/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}