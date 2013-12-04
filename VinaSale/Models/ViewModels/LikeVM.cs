using System;

namespace VinaSale.Models.ViewModels
{
    public class LikeVM
    {
        public long LikeId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}