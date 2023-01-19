namespace PS.MelonRestaurant.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string imageUrl { get; set; } = string.Empty;
    }
}
