using DataAccessLayer.Context;
using Divar.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDivar3.ViewComponents.AdvertViewComponents
{
    [ViewComponent]
    public class AdvertViewComponents : ViewComponent
    {
        private IAdvert _iadvert;
        private DivarContext _context;

        public AdvertViewComponents(IAdvert iadvert, DivarContext context)
        {
            _iadvert = iadvert;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = _context.Users.FirstOrDefault(u => u.Mobile == User.Identity.Name);

            return await Task.FromResult((IViewComponentResult)View("ShowAdverts", _iadvert.ShowAdvert(user.Id)));

        }
    }
}
