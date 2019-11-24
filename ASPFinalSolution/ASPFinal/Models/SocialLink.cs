using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class SocialLink
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public int? OrderBy { get; set; }
        public bool Status { get; set; }
    }
}