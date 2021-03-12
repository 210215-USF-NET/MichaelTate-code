using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBL;
using AppMVC.Models;

namespace AppMVC.Controllers
{
    public class UserController : Controller
    {
        private IApplicationBL _appBL;
        private IMapper _mapper;

        public UserController(IApplicationBL appBL, IMapper mapper)
        {
            _appBL = appBL;
            _mapper = mapper;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View(_appBL.GetUser().Select(user => _mapper.Cast2UserIndexVM(user)).ToList());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View("CreateUser");
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserCRVM newUser)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _appBL.AddUser(_mapper.Cast2User(newUser));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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