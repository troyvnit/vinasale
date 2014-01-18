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
            PostAvatar = "/UserFiles/Images/logo.png";
        }
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostShortDescription { get; set; }
        public string PostDescription { get; set; }
        public string PostAvatar { get; set; }
        public string PostTags { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Priority { get; set; }
        public PostSize PostSize { get; set; }
        public PostType PostType { get; set; }
        public bool IsActived { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int BrandId { get; set; }
        public virtual BrandVM Brand { get; set; }
    }
}