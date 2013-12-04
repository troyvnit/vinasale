using System.ComponentModel.DataAnnotations;

namespace VinaSale.Models.ViewModels
{
    public class MediaVM
    {
        [Key]
        public int MediaId { get; set; }
        public string MediaName { get; set; }
        public string MediaUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public MediaTypeVM MediaType { get; set; }
    }

    public enum MediaTypeVM
    {
        Image, Video
    }
}