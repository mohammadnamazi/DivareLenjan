using DataAccessLayer.Entites;
using Divar.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Divar.Core.Interface
{
    public interface IAdmins
    {
        List<User> ShowAllUsers();
        List<Advert> ShowAllAdverts();
        List<AdvertField> ShowAdvertFields(int id);

        User UserDetail(int id);
        bool UserUpdate(UserViewModel user);
        List<Role> RoleDetails();
        Advert Showadvert(int id);
        bool DeleteAdvert(int id);
    }
}
