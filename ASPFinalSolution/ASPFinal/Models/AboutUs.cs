using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}