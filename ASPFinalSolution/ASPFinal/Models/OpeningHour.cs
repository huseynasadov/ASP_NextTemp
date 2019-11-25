using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum Days {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class OpeningHour
    {
        public int Id { get; set; }
        public Days Days { get; set; }
        [MaxLength(4)]
        public string BeginHour { get; set; }
        [MaxLength(4)]
        public string EndHour { get; set; }
        public Job Job { get; set; }
        public int JobId { get; set; }
    }
}