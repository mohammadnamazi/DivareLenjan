using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entites;


namespace Divar.Core.Interface
{
    public interface IAdvert
    {
        List<Category> ShowCategory();
        int AddAvert(Advert advert);
        List<Advert> ShowAdvert(int userId);
        bool RemoveAdvert(int id);
        Advert DetailAdvert(int id);
        bool UpdateAdvert(string name, string dec, bool IsExpire, int id);
        List<AdvertField> ShowAdvertFields(int id);
        List<CategoryField> ShowCategoryFields(int id);
        int AddAdvertField(AdvertField advertField);
        int RmoveAdvertField(int id);
        int AddGallery(Gallary gallary, int id);
        List<Gallary> ShowGallery(int id);
        int RemoveGallery(int id);
        List<City> ShowCity(string name);
        List<Advert> ShowAdvertsByCity(int id, int pageNumber);
        Gallary FirstAdvertImage(int id);
        Advert ShowAdvertById(int id);
        int AddMark(int advertid, int userid);
        bool ExistMark(int advertid, int userid);
        List<Mark> ShowUserMark(int id);
        bool RemoveMark(int id);
        bool ExistVisit(int userid, int advertid);
        int AddVisit(Visit visit);
        int UpdateVisit(int userid, int advertid, string date, string time);
        List<Visit> ShowUserVisits(int id);

    }
}
