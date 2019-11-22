using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Partner
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped, Display(Name = "Photo Upload")]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public int? OrderBy { get; set; }
        public bool Status { get; set; }
    }
}