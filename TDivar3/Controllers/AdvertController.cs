using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Divar.Core.Services;
using Divar.Core.Interface;
using DataAccessLayer.Entites;
using Divar.Core.ViewModel;
using System.Globalization;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using Divar.Core.Classes;
using System.IO;


namespace TDivar3.Controllers
{
    [Authorize]
    public class AdvertController : Controller
    {
        PersianCalendar pc = new PersianCalendar();
        private IAdvert _iadvert;
        private DivarContext _context;

        public AdvertController(IAdvert iadvert, DivarContext context)
        {
            _iadvert = iadvert;
            _context = context;
        }
        public IActionResult AddMark(int advertid, int userid)
        {
            _iadvert.AddMark(advertid, userid);

            return RedirectToAction("Index", "Profile");
        }
        public IActionResult RemoveMark(int id)
        {
            _iadvert.RemoveMark(id);

            return RedirectToAction("Index", "Profile");
        }
        public IActionResult Index()
        {
            var category = _iadvert.ShowCategory();
            return View(category);

        }
        public IActionResult Create(int id)
        {
            ViewBag.CityId = new SelectList(_iadvert.ShowCity(""), "Id", "Name");
            return View();

        }

        [HttpPost]
        public IActionResult Create(int id, AdvertViewModel advert)
        {
            if (ModelState.IsValid)
            {
                if (advert.Des != null && advert.Name != null)
                {
                    string strToday = pc.GetYear(DateTime.Now).ToString("0000") + "/" +
                                     pc.GetMonth(DateTime.Now).ToString("00") + "/" +
                                     pc.GetDayOfMonth(DateTime.Now).ToString("00");
                    var user = _context.Users.FirstOrDefault(u => u.Mobile == User.Identity.Name);
                    Advert ads = new Advert()
                    {
                        CityId = advert.CityId,
                        CategoryId = id,
                        Date = strToday,
                        IsExpire = false,
                        Seen = 0,
                        UserId = user.Id,
                        Name = advert.Name,
                        Des = advert.Des
                    };
                    _iadvert.AddAvert(ads);
                    return RedirectToAction("Index", "Profile");
                }
                else
                {
                    ModelState.AddModelError("Des", "لطفا تمامی موارد را  تکمیل نمایید");
                    return View();
                }
            }
            else
            {
                return View(advert);
            }

        }
        public IActionResult Delete(int? id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _iadvert.RemoveAdvert(id);
            }
            return RedirectToAction("Index", "Profile");
        }
        public IActionResult Details(int id)
        {
            return View(_iadvert.DetailAdvert(id));

        }
        public IActionResult Edit(int id)
        {
            var ads = _iadvert.DetailAdvert(id);

            EditAdvertViewModel edit = new EditAdvertViewModel()
            {
                Des = ads.Des,
                Name = ads.Name,
                IsExpire = ads.IsExpire
            };

            return View(edit);

        }
        [HttpPost]
        public IActionResult Edit(EditAdvertViewModel advert, int id)
        {

            if (advert.Des != null && advert.Name != null)
            {
                if (ModelState.IsValid)
                {
                    _iadvert.UpdateAdvert(advert.Name, advert.Des, advert.IsExpire, id);

                    return RedirectToAction("Index", "Profile");
                }
                else
                {
                    return View(advert);
                }
            }
            else
            {
                return View(advert);
            }




        }
        public IActionResult ShowAdvertFields(int id)
        {
            var advertField = _iadvert.ShowAdvertFields(id);
            ViewBag.MyId = id;
            return View(advertField);
        }
        public IActionResult AddAdvertFields(int id)
        {
            AddAdvertFieldViewModel addAdvert = new AddAdvertFieldViewModel();
            addAdvert.Id = id;
            ViewBag.FieldId = new SelectList(_iadvert.ShowCategoryFields(id), "Field.Id", "Field.Name");
            return View(addAdvert);
            
        }
        [HttpPost]
        public IActionResult AddAdvertFields(int id, AddAdvertFieldViewModel addAdvert)
        {
            if (addAdvert.Value != null && addAdvert.FieldId != 0)
            {
                if (ModelState.IsValid)
                {

                    AdvertField advertField = new AdvertField()
                    {
                        AdvertId = id,
                        FieldId = addAdvert.FieldId,
                        FieldValue = addAdvert.Value
                    };

                    _iadvert.AddAdvertField(advertField);

                    return Redirect("/Advert/ShowAdvertFields/" + id);
                }
                else
                {
                    return PartialView();
                }


            }
            else
            {
                ViewBag.FieldId = new SelectList(_iadvert.ShowCategoryFields(id), "Field.Id", "Field.Name");
                return View(addAdvert);

            }

        }
        public IActionResult DeleteAdvertField(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteAdvertField(int id)
        {
            if (ModelState.IsValid)
            {
                int advertId = _iadvert.RmoveAdvertField(id);

                return Redirect("/Advert/ShowAdvertFields/" + advertId);
            }

            return RedirectToAction("Index", "Profile");
        }
        public IActionResult CreateGallery(int id)
        {
            AddGalleryViewModel addGallery = new AddGalleryViewModel();
            addGallery.Id = id;
            return View(addGallery);
        }

        [HttpPost]
        public IActionResult CreateGallery(AddGalleryViewModel addGallery, int id)
        {
            if (ModelState.IsValid)
            {
                if (addGallery.Img != null)
                {
                    string imgPath = "";
                    addGallery.ImgName = CodeGenerators.ImgCode() + Path.GetExtension(addGallery.Img.FileName);

                    imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/adverts", addGallery.ImgName);

                    using (var stream = new FileStream(imgPath, FileMode.Create))
                    {
                        addGallery.Img.CopyTo(stream);
                    }

                    Gallary gallery = new Gallary()
                    {
                        AdvertId = id,
                        Image = addGallery.ImgName
                    };

                    _iadvert.AddGallery(gallery, id);

                    return Redirect("/Advert/ShowGallery/" + id);
                }
                else
                {
                    ModelState.AddModelError("Img", "لطفا قبل از  کلیک بر روی گزینه ذخیره یک عکس بارگزاری نمایید!!!");
                    return View(addGallery);
                }
            }
            else
            {
                return View(addGallery);
            }
        }
        public IActionResult ShowGallery(int id)
        {
            var gallery = _iadvert.ShowGallery(id);

            ViewBag.MyId = id;

            return View(gallery);

        }
        public IActionResult DeleteGallery(int? id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteGallery(int id)
        {
            if (ModelState.IsValid)
            {
                int advertId = _iadvert.RemoveGallery(id);

                return Redirect("/Advert/ShowGallery/" + advertId);
            }

            return View();
        }

    }
}