using AutoMapper;
using FoodEcom.Services.OrderAPI;
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
                config.CreateMap<OrderHeaderDto, CartHeaderDto>()
                .ForMember(dest => dest.CartTotal, u => u.MapFrom(src => src.OrderTotal)).ReverseMap();


                config.CreateMap<CartDetailsDto, OrderDetailsDto>()
                .ForMember(dest => dest.ProductName, u => u.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.Price, u => u.MapFrom(src => src.Product.Price));

                config.CreateMap<OrderHeader, OrderHeaderDto>().ReverseMap();
				config.CreateMap<OrderDetails, OrderDetailsDto>().ReverseMap();
			});
            return mappingConfig;
        }
    }
}
