using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(300)]
        public string Content { get; set; }
        [Required, MaxLength(100)]
        public string Icon { get; set; }
        public int? OrderBy { get; set; }
        public bool Status { get; set; }
    }
}