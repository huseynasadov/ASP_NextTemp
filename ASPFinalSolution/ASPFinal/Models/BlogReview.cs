using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class BlogReview
    {
        public int Id { get; set; }
        public Candidate Candidate { get; set; }
        public int CandidateId { get; set; }
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}