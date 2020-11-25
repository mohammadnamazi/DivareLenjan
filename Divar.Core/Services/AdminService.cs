using DataAccessLayer.Context;
using DataAccessLayer.Entites;
using Divar.Core.Interface;
using Divar.Core.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divar.Core.Services
{
    public class AdminService : IAdmins
    {
        private DivarContext _context;
        public AdminService(DivarContext context)
        {
            _context = context;
        }

        public bool DeleteAdvert(int id)
        {
            var ads = _context.Adverts.Find(id);
            _context.Remove(ads);
            _context.SaveChanges();
            return true;
        }

        public List<Role> RoleDetails()
        {
            return _context.Roles.Where(c => c.Name.Contains("")).OrderBy(c => c.Name).ToList();
        }

        public Advert Showadvert(int id)
        {
            Advert advert = _context.Adverts.Include(a => a.User).FirstOrDefault(a => a.Id == id);
            return advert; 
        }

        public List<AdvertField> ShowAdvertFields(int id)
        {
            var fields = _context.AdvertFields.Include(a => a.Field).Where(a => a.AdvertId == id).ToList();

            return fields;
        }

        public List<Advert> ShowAllAdverts()
        {
            return _context.Adverts.Include(a => a.Category).OrderByDescending(a => a.Date).ToList();

        }

        public List<User> ShowAllUsers()
        {
            return _context.Users.Include(u => u.Role).OrderByDescending(u => u.Id).ToList();
        }

        public User UserDetail(int id)
        {
            User user = _context.Users.Find(id);
            return user;
        }

        public bool UserUpdate(UserViewModel userr)
        {
            User user = _context.Users.Find(userr.Id);
            if(user != null)
            {
                user.RoleId = int.Parse(userr.Name);
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
