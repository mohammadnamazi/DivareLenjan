using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Entites;
using Divar.Core.Classes;
using Divar.Core.Interface;
using Divar.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TDivar3.Controllers
{
    [RoleAttribute("Admin")]
    public class AdminsController : Controller
    {
        private IAdmins _iadmin;
        private IUser _iuser;
        private IAdvert _iadvert;

        public AdminsController(IAdmins iadmin,IUser iuser,IAdvert iadvert)
        {
            _iadmin = iadmin;
            _iuser = iuser;
            _iadvert = iadvert;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ShowFields(int id)
        {
            var advert = _iadmin.Showadvert(id);
            return View(advert);
        }
        public IActionResult Delete(int? id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid && id != 2)
            {
                _iuser.RemoveUser(id);
            }
            return RedirectToAction("Index", "Admins");
        }

        public IActionResult DeleteAdvert(int? id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteAdvert(int id)
        {
            if (ModelState.IsValid)
            {
                _iadvert.RemoveAdvert(id);
            }
            return RedirectToAction("Index", "Admins");
        }

        public IActionResult EditUser(int id)
        {
            ViewBag.Name = new SelectList(_iadmin.RoleDetails(),"Id","Name");
            User user = _iadmin.UserDetail(id);

            return View();
        }

        [HttpPost]
        public IActionResult EditUser(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                _iadmin.UserUpdate(user);

                return RedirectToAction("Index", "Admins");
            }
            else
            {
                return View();
            }
        }
    }
}
