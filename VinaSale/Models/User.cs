using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinaSale.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get;set; }
        public DateTime DateOfBirth { get;set; }
        public string ProfilePicture { get;set; }
        public ICollection<Brand> Brands { get;set; }
    }
}