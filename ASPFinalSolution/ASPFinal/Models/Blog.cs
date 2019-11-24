using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Title { get; set; }
        [Required, MaxLength(200)]
        public string Slug { get; set; }
        [Required,Column(TypeName ="ntext")]
        public string Content { get; set; }
        [MaxLength(250)]
        public string Photos { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [DataType(DataType.Date),Column(TypeName ="date")]
        public DateTime CreatedAt { get; set; }
        public ICollection<BlogReview> BlogReview { get; set; }
        public JobCategory Category { get; set; }
        public int CategoryId { get; set; }
        public bool Status { get; set; }
    }
}