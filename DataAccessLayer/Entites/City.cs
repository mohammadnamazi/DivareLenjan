using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entites
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="نام شهر")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نباید بیش از {1} باشد")]
        public string Name { get; set; }
        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
