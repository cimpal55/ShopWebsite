namespace ShopWebsite.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task<ServiceResponse<Product>> GetProduct(int productId);
        Task GetProductsAsync(string? categoryUrl = null);
    }
}
