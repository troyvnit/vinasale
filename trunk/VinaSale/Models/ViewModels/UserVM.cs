using System;
using System.ComponentModel.DataAnnotations;

namespace VinaSale.Models.ViewModels
{
    public class UserVM
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get;set; }
        public DateTime DateOfBirth { get;set; }
        public string ProfilePicture { get;set; }
    }
}