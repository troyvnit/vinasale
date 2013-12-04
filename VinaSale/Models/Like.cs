using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinaSale.Models
{
    public class Like
    {
        public long LikeId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}