using PS.MelonRestaurant.Web.Models;
using PS.MelonRestaurant.Web.Services.IServices;

namespace PS.MelonRestaurant.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            var apiRequest = new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products/",
                AccessToken = ""
            };
            return await this.SendAsync<T>(apiRequest);
        }

        public async Task<T> GetProductByIdAsync<T>(Guid id)
        {
            var apiRequest = new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/products/" + id,
                AccessToken = ""
            };
            return await this.SendAsync<T>(apiRequest);
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            var apiRequest = new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products/",
                AccessToken = ""
            };
            return await this.SendAsync<T>(apiRequest);
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            var apiRequest = new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = productDto,
                Url = SD.ProductAPIBase + "/api/products/",
                AccessToken = ""
            };
            return await this.SendAsync<T>(apiRequest);
        }

        public async Task<T> DeleteProductAsync<T>(Guid id)
        {
            var apiRequest = new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ProductAPIBase + "/api/products/" + id,
                AccessToken = ""
            };
            return await this.SendAsync<T>(apiRequest);
        }
    }
}
