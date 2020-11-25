using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entites;
using Divar.Core.Interface;
using DataAccessLayer.Context;
using System.Linq;
using Divar.Core;
using Divar.Core.Classes;
using Microsoft.EntityFrameworkCore;

namespace Divar.Core.Services
{
    public class UserService : IUser
    {
        DivarContext _context;

        public UserService(DivarContext context)
        {
            _context = context; 
        }

        public bool ActiveUser(string ActiveCode)
        {
            var user = _context.Users.FirstOrDefault(u => u.IsActive==false && u.Code == ActiveCode);

            if( user != null)
            {
                user.Code = CodeGenerators.ActiveCode();
                user.IsActive = true;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user.Id;
        }

        public bool ChangePassword(string MobileNumber, string CurentPassword, string Password)
        {
            var HashCurentPassword = HashGenerator.EncodingPassWMD5(Password);
            var user = _context.Users.FirstOrDefault(u => u.Mobile == MobileNumber && u.Password == HashCurentPassword);

            if(user !=null)
            {
                user.Password = HashCurentPassword;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUserRole(string roleName, string mobileNumber)
        {
            return _context.Users.Include(u => u.Role).Any(u => u.Mobile == mobileNumber && u.Role.Name == roleName);
        }

        public User ForgetPassword(string MobileNumber)
        {
            return _context.Users.FirstOrDefault(u => u.Mobile == MobileNumber);
        }

        public string GetRoleName(int id)
        {
            var rol = _context.Roles.Find(id);
            return rol.Name;
        }

        public int GetUserId(string MobileNumber)
        {
            var User = _context.Users.FirstOrDefault(u => u.Mobile == MobileNumber);
            return User.Id;
        }

        public bool IfMobileNumberExist(string moblienumber)
        {
            return _context.Users.Any(u => u.Mobile == moblienumber);
        }

        public User LoginUser(string MobileNumber, string Password)
        {
            string HashPassword = HashGenerator.EncodingPassWMD5(Password);
            return _context.Users.FirstOrDefault(u => u.Mobile == MobileNumber && u.Password == HashPassword);
        }

        public bool RemoveUser(int id)
        {
            var ads = _context.Users.Find(id);
            _context.Remove(ads);
            _context.SaveChanges();
            return true;
        }

        public bool ResetPasswor(string ActiveCode, string Password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Code == ActiveCode && u.IsActive==true);
            if( user!= null)
            {
                string HashP = HashGenerator.EncodingPassWMD5(Password);
                user.Password = HashP;
                user.Code = CodeGenerators.ActiveCode();
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
