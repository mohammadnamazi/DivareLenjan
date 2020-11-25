using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entites
{
    public class Advert
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public int UserId { get; set; }
        [Display(Name = "عنوان آگهی")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نباید بیش از {1} باشد")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Des { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        [MaxLength(10, ErrorMessage = "مقدار {0} نباید بیش از {1} باشد")]
        public string Date { get; set; }
        [Display(Name = "تعداد بازدید")]
        public int Seen { get; set; }
        [Display(Name = "منقضی")]
        public bool IsExpire { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<AdvertField> AdvertFields_Advert { get; set; }
        public virtual ICollection<Gallary> Gallaries_Advert { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
