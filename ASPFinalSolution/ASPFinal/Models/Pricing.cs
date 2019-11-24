using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        [Required,MaxLength(15)]
        public string Name { get; set; }
        public int Amount { get; set; }
        public byte Bandwidth { get; set; }
        public byte Onlinespace { get; set; }
        public bool Support { get; set; }
        public byte Domain { get; set; }
        public bool Fees { get; set; }
        public int? OrderBy { get; set; }
        public bool Status { get; set; }
    }
}