using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PS.MelonRestaurant.Web.Models;
using PS.MelonRestaurant.Web.Services.IServices;

namespace PS.MelonRestaurant.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> products = new List<ProductDto>();
            var response = await _productService.GetAllProductsAsync<ResponseDto>();

            if(response.Result != null && response.IsSuccess)
            {
                products = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }

            return View(products);
        }
    }
}
