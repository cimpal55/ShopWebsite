﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebsite.Shared.Models.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = "https://via.placeholder.com/300x300";
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductVariant> Variants { get; set; } = new();
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
