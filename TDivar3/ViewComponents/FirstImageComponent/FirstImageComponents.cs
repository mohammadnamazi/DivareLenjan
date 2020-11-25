using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Entites;
using Divar.Core.Interface;
using Divar.Core.Services;

namespace TDivar3.ViewComponents.FirstImageComponent
{
    public class FirstImageComponent : ViewComponent
    {
        IAdvert _iadvert;
        public FirstImageComponent( IAdvert iadvert)
        {
            _iadvert = iadvert;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("ShowFirstImage", _iadvert.FirstAdvertImage(id)));
        }
    }
}
