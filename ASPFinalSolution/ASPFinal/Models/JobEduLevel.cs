using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class JobEduLevel
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Name { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}