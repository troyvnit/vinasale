using System.ComponentModel.DataAnnotations;

namespace VinaSale.Models.ViewModels
{
    public class BrandVM
    {
        public BrandVM()
        {
            UserId = 1;
        }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }
        public BrandTypeVM BrandType { get; set; }
        public int UserId { get; set; }
    }

    public enum BrandTypeVM
    {
        Company, Shop
    }
}