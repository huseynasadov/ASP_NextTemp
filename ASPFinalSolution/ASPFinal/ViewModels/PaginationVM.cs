using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public enum PagePag {
        Home,
        Job,
        Candidate,
        Blog
    }
    public class PaginationVM
    {
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public PagePag Page { get; set; }
    }
}