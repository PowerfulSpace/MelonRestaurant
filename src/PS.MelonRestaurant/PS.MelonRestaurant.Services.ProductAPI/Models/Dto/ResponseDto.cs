namespace PS.MelonRestaurant.Services.ProductAPI.Models.Dto
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; } = null!;
        public string Message { get; set; } = string.Empty;
        public List<string> ErrorMessage { get; set; } = null!;
    }
}
