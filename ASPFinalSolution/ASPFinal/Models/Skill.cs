using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int? Degree { get; set; }
        public Candidate Candidate { get; set; }
        public int CandidateId { get; set; }
    }
}