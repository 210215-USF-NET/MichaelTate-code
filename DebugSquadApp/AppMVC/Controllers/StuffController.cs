using AppBL;
using AppMVC.Models;
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
        private IApplicationBL _appBL;
        private IMapper _mapper;

        public StuffController(IApplicationBL appBL, IMapper mapper)
        {
            _appBL = appBL;
            _mapper = mapper;
        }

        // GET: StuffController
        public ActionResult Index()
        {
            return View(_appBL.GetStuff().Select(stuff => _mapper.Cast2StuffIndexVM(stuff)).ToList());
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
        public ActionResult Create(StuffCRVM newStuff)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _appBL.AddStuff(_mapper.Cast2Stuff(newStuff));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: StuffController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: StuffController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

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