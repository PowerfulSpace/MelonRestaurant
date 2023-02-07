using PS.MelonRestaurant.Web.Models;

namespace PS.MelonRestaurant.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        public ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
