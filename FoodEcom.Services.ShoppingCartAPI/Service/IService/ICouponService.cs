using FoodEcom.Services.ShoppingCartAPI.Models.Dto;

namespace FoodEcom.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
