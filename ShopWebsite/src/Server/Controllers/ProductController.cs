using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new()
        {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
            },
            new Product
            {
                Id = 2,
                CategoryId = 3,
                Title = "Half-Life 2",
                Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                Price = 8.19m,
                OriginalPrice = 29.99m,
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(Products);
        }
    }
}
