using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class Breadcrumb
    {
        public string Title { get; set; }
        public Dictionary<string, string> Path { get; set; }
    }
}