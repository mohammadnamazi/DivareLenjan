using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entites
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Parent")]
        public int? Parentid { get; set; }
        [Display(Name = "نام دسته")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نباید بیش از {1} باشد")]
        public string Name { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Advert> Adverts { get; set; }
        public virtual ICollection<CategoryField> CategoryFields { get; set; }
    }
}
