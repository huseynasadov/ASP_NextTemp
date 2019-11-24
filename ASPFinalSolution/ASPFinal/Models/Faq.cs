using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum CategoryFaq { General,Career} 
    public class Faq
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool Status { get; set; }
        public int? OrderBy { get; set; }
        public CategoryFaq CategoryFaq { get; set; }
    }
}