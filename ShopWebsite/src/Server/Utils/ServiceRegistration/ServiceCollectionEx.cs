namespace ShopWebsite.Server.Utils.ServiceRegistration
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddShopWebsiteServices(this IServiceCollection @this) =>
            @this
                .AddServices();

        private static IServiceCollection AddServices(this IServiceCollection @this) =>
            @this
                .AddScoped<IProductService, ProductService>();
    }
}
