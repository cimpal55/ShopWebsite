﻿namespace ShopWebsite.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                                        .Include(p => p.Variants)
                                        .ThenInclude(v => v.ProductType)
                                        .FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist.";
            }
            else
            {
                response.Data = product;
            }
            
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(p => p.Variants).ToListAsync()
            };

            return response;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                    .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                    .Include(p => p.Variants)
                    .ToListAsync()
            };

            return response;
        }
        public async Task<ServiceResponse<List<Product>>> SearchProducts(string searchString)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await FindProductsBySearchString(searchString)
            };

            return response;
        }

        private async Task<List<Product>> FindProductsBySearchString(string searchString)
        {
            return await _context.Products
                                .Where(p => p.Title.ToLower().Contains(searchString.ToLower())
                                || p.Description.ToLower().Contains(searchString.ToLower()))
                                .Include(p => p.Variants)
                                .ToListAsync();
        }

        public async Task<ServiceResponse<List<string>>> SearchSuggestions(string searchString)
        {
            var products = await FindProductsBySearchString(searchString);

            List<string> result = new();

            foreach (var product in products)
            {
                if (product.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }
                else if (product.Description != null)
                {
                    var punctuation = product.Description.Where(char.IsPunctuation)
                            .Distinct().ToArray();
                    var words = product.Description.Split()
                        .Select(s => s.Trim(punctuation));
                    
                    foreach (var word in words)
                    {
                        if (word.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                            && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }
            }

            return new ServiceResponse<List<string>> { Data = result };
        }
    }
}
