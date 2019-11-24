using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Education
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string University { get; set; }
        [MaxLength(50)]
        public string CourseTitle { get; set; }
        [MaxLength(100)]
        public string EduAddition { get; set; }
        public JobEduLevel JobEduLevel { get; set; }
        public int? JobEduLevelId { get; set; }
        [Column(TypeName ="date"),DataType(DataType.Date)]
        public DateTime BeginDate { get; set; }
        [Column(TypeName = "date"), DataType(DataType.Date)]
        public DateTime FinalDate { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}