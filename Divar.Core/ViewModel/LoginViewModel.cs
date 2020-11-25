using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Divar.Core.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "شماره تلفن همراه")]
        [Required(ErrorMessage = "{0} راوارد نمایید")]
        [MaxLength(11, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]

        public string Mobile { get; set; }
        [Display(Name = "رمز عبور")]
        [MaxLength(50, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا بخاطر بسپار")]
        public bool RemmberMe { get; set; }
    }
}
