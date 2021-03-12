using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVC.Controllers
{
    public class StuffController : Controller
    {
        // GET: StuffController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StuffController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StuffController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StuffController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StuffController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StuffController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StuffController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StuffController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
