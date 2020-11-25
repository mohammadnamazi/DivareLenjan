using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Divar.Core.ViewModel
{
    public class ForgetViewModel
    {
        [Display(Name = "شماره تلفن همراه")]
        [Required(ErrorMessage = "{0} راوارد نمایید")]
        [MaxLength(11, ErrorMessage = "مقدار {0}نباید بیشتر از {1} باشد ")]
        public string Mobile { get; set; }
    }
}
