using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entites
{
    public class AdvertField
    {
        [Key]
        public int Id { get; set; }
        public int AdvertId { get; set; }
        public int FieldId { get; set; }
        [Display(Name = "مقدار")]
        [Required(ErrorMessage = "محتوای {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نباید بیش از {1} باشد")]
        public string FieldValue { get; set; }
        [ForeignKey("AdvertId")]
        public virtual Advert Advert { get; set; }
        [ForeignKey("FieldId")]
        public Field Field { get; set; }
    }
}
