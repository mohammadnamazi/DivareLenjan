using Divar.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDivar3.ViewComponents.AdminGalleryComponent
{
    public class AdminGalleryComponent : ViewComponent
    {
        private IAdvert _iadvert;

        public AdminGalleryComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("AdminGallery", _iadvert.ShowGallery(id)));
        }
    }
}
