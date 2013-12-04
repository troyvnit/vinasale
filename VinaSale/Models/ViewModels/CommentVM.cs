using System;

namespace VinaSale.Models.ViewModels
{
    public class CommentVM
    {
        public long CommentId { get; set; }
        public string CommentContent { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}