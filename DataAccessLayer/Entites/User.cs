using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entites
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public int RoleId { get; set; }
        [Display(Name ="شماره تلفن همراه")]
        [Required(ErrorMessage ="{0} راوارد نمایید")]
        [MaxLength(11,ErrorMessage ="مقدار {0}نباید بیشتر از {1} باشد ")]
        public string Mobile { get; set; }
        [Display(Name = "رمز عبور")]
        [MaxLength(50, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]
        public string Password { get; set; }
        [Display(Name = "کد فعال سازی")]
        [MaxLength(6, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]
        public string Code { get; set; }
        [Display(Name = "فعال/غیر فعال")]
        public bool IsActive { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public virtual ICollection<Advert> Adverts_User { get; set; }

    }
}
