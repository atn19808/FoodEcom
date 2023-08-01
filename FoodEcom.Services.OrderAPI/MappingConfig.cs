using AutoMapper;
using FoodEcom.Services.OrderAPI.Models;
using FoodEcom.Services.OrderAPI.Models.Dto;

namespace FoodEcom.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<OrderHeader, OrderHeaderDto>().ReverseMap();
				config.CreateMap<OrderDetails, OrderDetailsDto>().ReverseMap();
			});
            return mappingConfig;
        }
    }
}
