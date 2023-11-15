using AutoMapper;
using FoodEcom.Services.ProductAPI.Models;
using FoodEcom.Services.ProductAPI.Models.Dto;

namespace FoodEcom.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
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
