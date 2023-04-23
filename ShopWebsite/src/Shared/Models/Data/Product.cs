using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebsite.Shared.Models.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = "https://via.placeholder.com/300x300";
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
