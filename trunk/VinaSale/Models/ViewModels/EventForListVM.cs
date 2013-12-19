using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinaSale.Models.ViewModels
{
    public class EventForListVM
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string PostShortDescription { get; set; }
        public string PostAvatar { get; set; }
        public string PostTags { get; set; }
        public int Priority { get; set; }
        public PostSize PostSize { get; set; }
        public PostType PostType { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual BrandVM Brand { get; set; }
    }
}