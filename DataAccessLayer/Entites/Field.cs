using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entites
{
    public class Field
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "نام مشخصه")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نباید بیش از {1} باشد")]
        public string Name { get; set; }
        [Display(Name = "مخفی در ویژگی")]
        public bool HideInFilter { get; set; }
        public virtual ICollection<AdvertField> AdvertFields_Field { get; set; }
        public virtual ICollection<CategoryField> CategoryFields { get; set; }
    }
}
