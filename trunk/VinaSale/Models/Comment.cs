using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinaSale.Models
{
    public class Comment
    {
        public long CommentId { get; set; }
        public string CommentContent { get; set; }
        public ICollection<Like> Likes { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}