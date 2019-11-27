using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Areas.Control.Models
{
    public class LoginVM
    {
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required()]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}