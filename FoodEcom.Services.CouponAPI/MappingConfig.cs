using AutoMapper;
using FoodEcom.Services.CouponAPI.Models;
using FoodEcom.Services.CouponAPI.Models.Dto;

namespace FoodEcom.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
				config.CreateMap<Coupon, CouponDto>();
			});
            return mappingConfig;
        }
    }
}
