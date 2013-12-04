using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinaSale.Models
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; }
        public string MediaName { get; set; }
        public string MediaUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public MediaType MediaType { get; set; }
    }

    public enum MediaType
    {
        Image, Video
    }
}