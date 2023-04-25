﻿namespace ShopWebsite.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl);
        Task<ServiceResponse<List<Product>>> SearchProducts(string searchString);
        Task<ServiceResponse<List<string>>> SearchSuggestions(string searchString);
        Task<ServiceResponse<List<Product>>> GetFeaturedProductsAsync();

    }
}
