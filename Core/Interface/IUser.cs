using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Context;
using DataAccessLayer.Entites;

namespace Core.Interface
{
    interface IUser
    {
        bool IfMobileNumberExist(string moblienumber);
        int AddUser(User user);

    }
}
