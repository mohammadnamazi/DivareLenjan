using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.ViewModel;
using Divar.Core.Services;
using Divar.Core.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace TDivar3.Controllers   
{
    [Authorize]
    public class ProfileController : Controller
    {
        private IUser _iuser;
        public ProfileController(IUser iuser)
        {
            _iuser = iuser;
        }
        public IActionResult Index()
        {
            ViewBag.MyId = _iuser.GetUserId(User.Identity.Name);
            return View();
        }
        public IActionResult ChengePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChengePassword(ChangePasswordViewModel change)
        {
            string UserName = User.Identity.Name;

            if(_iuser.ChangePassword(UserName,change.CurentPassword,change.Password))
            {
                return RedirectToAction("LogOut", "Account");
            }
            else
            {
                ModelState.AddModelError("CurentPassword", "رمز عبور فعلی صحیح نیست");
                return View(change);
            }
        }
    }
}
