using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.ViewModels
{
    public class UserVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public DateTime? Date { get; set; }
    }
}