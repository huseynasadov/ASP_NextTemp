using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class EmployerCategory
    {
        public int Id { get; set; }
        public JobCategory Category { get; set; }
        public int CategoryId { get; set; }
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }
    }
}