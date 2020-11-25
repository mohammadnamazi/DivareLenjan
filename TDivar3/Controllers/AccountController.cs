using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.ViewModel;
using Divar.Core.Interface;
using DataAccessLayer.Entites;
using Divar.Core.Classes;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace TDivar3.Controllers
{
    public class AccountController : Controller
    {
        private IUser _iuser;

        public AccountController(IUser iuser)
        {
            _iuser = iuser;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                if (_iuser.IfMobileNumberExist(register.Mobile))
                {
                    
                    ModelState.AddModelError("Mobile", "شما قبلا ثبت نام کرده اید");
                    return View("Login");
                }
                else
                {
                    User user = new User()
                    {
                        IsActive = false,
                        Mobile = register.Mobile,
                        Code = CodeGenerators.ActiveCode(),
                        Password = HashGenerator.EncodingPassWMD5(register.Password),
                        RoleId = 2
                    };

                    _iuser.AddUser(user);

                    SMS sms = new SMS();

                    sms.Send(user.Mobile, "ثبت نام شما انجام شد، کد فعالسازی " + user.Code);

                    return RedirectToAction(nameof(Active));
                }
            }
            else
            {
                return View(register);
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var user = _iuser.LoginUser(login.Mobile, login.Password);

                if (user != null)
                {
                    if (user.IsActive)
                    {
                        var claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                            new Claim(ClaimTypes.Name, user.Mobile)
                        };

                        var identity = new ClaimsIdentity(claims, "UserCookie");
                        var principal = new ClaimsPrincipal(identity);

                        var properties = new AuthenticationProperties()
                        {
                            IsPersistent = login.RemmberMe
                        };

                        HttpContext.SignInAsync(principal, properties);

                        if (_iuser.GetRoleName(user.RoleId) == "Admin")
                        {
                            return RedirectToAction("Index", "Admins");
                        }
                        else if(_iuser.GetRoleName(user.RoleId) == "User")
                        {
                            return RedirectToAction("Index", "Profile");
                        }
                        else
                        {
                            ModelState.AddModelError("Mobile", "حساب شما در سایت مسدود شده است برای رفع انسداد با تیم پشتیبانی تماس بگیرید");
                            return View(login);
                        }

                        //return RedirectToAction("Index", "Profile");
                    }
                    else
                    {
                        SMS sms = new SMS();

                        sms.Send(user.Mobile, "دیوار لنجان   ثبت نام شما با موفقیت انجام شده کد فعال سازی:  " + user.Code);
                        return RedirectToAction(nameof(Active));
                    }
                }
                else
                {
                    ModelState.AddModelError("Password", "مشخصات کاربری صحیح نیست");

                    return View(login);
                }
            }
            else
            {
                return View(login);
            }
        }

        public IActionResult Active()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Active(ActiveViewModel active)
        {
            if (ModelState.IsValid)
            {
                if (_iuser.ActiveUser(active.Code))
                {
                    return RedirectToAction(nameof(Login));
                }
                else
                {
                    ModelState.AddModelError("Code", "کد فعالسازی شما صحیح نیست");

                    return View(active);
                }
            }
            else
            {
                return View(active);
            }
        }

        public IActionResult Forget()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Forget(ForgetViewModel forget)
        {
            if (ModelState.IsValid)
            {
                var user = _iuser.ForgetPassword(forget.Mobile);

                if (user != null)
                {
                    SMS sms = new SMS();

                    sms.Send(forget.Mobile, "کد تأیید برای فراموشی کلمه عبور " + user.Code + " می باشد");

                    return RedirectToAction(nameof(Reset));
                }
                else
                {
                    ModelState.AddModelError("Mobile", "شماره موبایل وارد شده هنوز ثبت نام نکرده است");

                    return View(forget);
                }
            }
            else
            {
                return View(forget);
            }
        }

        public IActionResult Reset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reset(RsetPasswordViewModel reset)
        {
            if (ModelState.IsValid)
            {
                if (_iuser.ResetPasswor(reset.Code, reset.Password))
                {
                    return RedirectToAction(nameof(Login));
                }
                else
                {
                    ModelState.AddModelError("Code", "کد تأیید وارد شده صحیح نیست");

                    return View(reset);
                }
            }
            else
            {
                return View(reset);
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync("UserCookie");
            return RedirectToAction(nameof(Login));
        }
    }
}