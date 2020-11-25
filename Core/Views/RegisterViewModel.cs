using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Core
{
    class RegisterViewModel
    {

        [Display(Name = "شماره تلفن همراه")]
        [Required(ErrorMessage = "{0} راوارد نمایید")]
        [MaxLength(11, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]
        
        public string Mobile { get; set; }
        [Display(Name = "رمز عبور")]
        [MaxLength(50, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [MaxLength(50, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="تکرار کلمه عبور با کلمه عبور همخوانی ندارد")]
        public string ConfirmPassword { get; set; }

    }
}
