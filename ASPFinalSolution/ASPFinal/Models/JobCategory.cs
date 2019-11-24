using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class JobCategory
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<Job> Job { get; set; }
    }
}