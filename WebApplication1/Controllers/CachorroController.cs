using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CachorroController : Controller
    {
        //GET: Cachorro
        public ActionResult Index()
        {
            return View(CachorroModel.CriarLista());
        }

        // GET: Cachorro/Details/5
        public ActionResult Details(int id)
        {
            var dog = CachorroModel.CriarLista()[id];
            return View(dog);
        }

        // GET: Cachorro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cachorro/Create
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

        // GET: Cachorro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cachorro/Edit/5
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

        // GET: Cachorro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cachorro/Delete/5
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