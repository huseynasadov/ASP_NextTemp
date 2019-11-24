using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Qualification
    {
        public int Id { get; set; }
        [Required, MaxLength(300)]
        public string Content { get; set; }
        public Job Job { get; set; }
        public int JobId { get; set; }
        public bool Status { get; set; }
    }
}