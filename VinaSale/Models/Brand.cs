using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinaSale.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
        public BrandType BrandType { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Product> Products { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }

    public enum BrandType
    {
        Company, Shop
    }
}