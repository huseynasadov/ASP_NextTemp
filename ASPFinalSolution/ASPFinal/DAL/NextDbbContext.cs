using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPFinal.DAL
{
    public class NextDbbContext : DbContext
    {
        public NextDbbContext(): base("NextConnextion")
        {

        }
    }
}