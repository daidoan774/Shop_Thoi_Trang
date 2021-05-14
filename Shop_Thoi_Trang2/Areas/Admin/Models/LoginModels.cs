using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop_Thoi_Trang2.Areas.Admin.Models
{
    public class LoginModels
    {
        [Required]
        public string UserName { set; get; }

        public string PassWord { set; get; }

        public bool RememberMe { set; get; }
    }
}