using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinaSale.Models
{
    public abstract class Post
    {
        [Key]
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
        public virtual Brand Brand { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Media> Medias { get; set; }
    }
}