using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Experience
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Company { get; set; }
        public int JobCategoryId { get; set; }
        public JobCategory Category { get; set; }
        [Column(TypeName = "date"), DataType(DataType.Date)]
        public DateTime BeginDate { get; set; }
        [Column(TypeName = "date"), DataType(DataType.Date)]
        public DateTime FinalDate { get; set; }
        public int? Salary { get; set; }
        [MaxLength(100)]
        public string Website { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public Candidate Candidate { get; set; }
        public int CandidateId { get; set; }
    }
}