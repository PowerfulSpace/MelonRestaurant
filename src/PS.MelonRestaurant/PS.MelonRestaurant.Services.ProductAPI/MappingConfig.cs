using AutoMapper;
using PS.MelonRestaurant.Services.ProductAPI.Models;
using PS.MelonRestaurant.Services.ProductAPI.Models.Dto;

namespace PS.MelonRestaurant.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
