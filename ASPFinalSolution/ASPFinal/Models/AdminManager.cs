using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum AdminPosition {
        Admin,
        Subadmin
    }
    public class AdminManager
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MaxLength(50)]
        public string Lastname { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Password must be long 8 symbol")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MaxLength(300)]
        public string Token { get; set; }
        public bool Status { get; set; }
        [MaxLength(500)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public AdminPosition AdminPosition { get; set; }

    }
}