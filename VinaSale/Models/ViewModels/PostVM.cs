using System;
using System.ComponentModel.DataAnnotations;

namespace VinaSale.Models.ViewModels
{
    public abstract class PostVM
    {
        public PostVM()
        {
            CreatedDate = UpdatedDate = DateTime.Now;
            BrandId = 1;
        }
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostShortDescription { get; set; }
        public string PostDescription { get; set; }
        public string PostAvatar { get; set; }
        public string PostTags { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public bool IsActived { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int BrandId { get; set; }
    }
}