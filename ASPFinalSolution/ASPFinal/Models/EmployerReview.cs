using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class EmployerReview
    {
        public int Id { get; set; }
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }
        public Candidate Candidate { get; set; }
        public int CandidateId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool Satuts { get; set; }
    }
}