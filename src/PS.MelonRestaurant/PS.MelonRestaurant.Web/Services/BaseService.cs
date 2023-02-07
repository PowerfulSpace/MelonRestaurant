using PS.MelonRestaurant.Web.Models;
using PS.MelonRestaurant.Web.Services.IServices;

namespace PS.MelonRestaurant.Web.Services
{
    public class BaseService : IBaseService
    {
        public ResponseDto ResponseModel { get; set; }
        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            ResponseModel = new ResponseDto();
            this.httpClient = httpClient;
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
