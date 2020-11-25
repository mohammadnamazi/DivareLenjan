using Divar.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDivar3.ViewComponents.AdminComponent
{
    public class AdminComponent : ViewComponent
    {
        private IAdmins _iadmin;
        public AdminComponent(IAdmins admins)
        {
            _iadmin = admins;   
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("AdminShow",_iadmin.ShowAllUsers()));
        }
    }
}
