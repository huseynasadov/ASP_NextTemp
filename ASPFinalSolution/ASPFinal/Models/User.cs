using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPFinal.Models
{
    public enum UserPosition {
        Employer,
        Candidate
    }
    public class User
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Username { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public UserPosition UserPosition { get; set; }
        [MaxLength(200)]
        public string Token { get; set; }
    }
}