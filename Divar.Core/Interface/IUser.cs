using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Context;
using DataAccessLayer.Entites;

namespace Divar.Core.Interface
{
    public interface IUser
    {
        bool IfMobileNumberExist(string moblienumber);
        int AddUser(User user);

        User LoginUser(string MobileNumber, string Password);

        bool ActiveUser(string ActiveCode);

        User ForgetPassword(string MobileNumber);

        bool ResetPasswor(string ActiveCode, string Password);
        bool ChangePassword(string MobileNumber, string CurentPassword, string Password);
        int GetUserId(string MobileNumber);
        bool CheckUserRole(string roleName, string mobileNumber);
        string GetRoleName(int id);
        bool RemoveUser(int id);
    }
}
