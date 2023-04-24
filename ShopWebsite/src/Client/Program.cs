global using ShopWebsite.Shared.Models.Data;
global using ShopWebsite.Shared.Models.Services;
global using System.Net.Http.Json;
global using ShopWebsite.Client.Services.ProductService;
global using ShopWebsite.Client.Services.CategoryService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopWebsite.Client;
using ShopWebsite.Client.Utils.ServiceRegistration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddShopWebsiteServices();

await builder.Build().RunAsync();
