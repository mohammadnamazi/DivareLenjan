using Divar.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDivar3.ViewComponents.AdminsAdvertsComponent
{
    public class AdminsAdvertsComponent : ViewComponent
    {
        private IAdmins _iadmin;

        public AdminsAdvertsComponent(IAdmins iadmin)
        {
            _iadmin = iadmin;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        { 
            return await Task.FromResult((IViewComponentResult)View("AdminAdvertShow",_iadmin.ShowAllAdverts()));
        }
    }
}
