using Divar.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDivar3.ViewComponents.AdvertFieldComponent
{
    public class AdvertFieldComponent : ViewComponent
    {

        private IAdvert _iadvert;

        public AdvertFieldComponent(IAdvert iadvert)
        {
            _iadvert = iadvert;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult((IViewComponentResult)View("ShowAdvertField", _iadvert.ShowAdvertFields(id)));
        }
    }
}
