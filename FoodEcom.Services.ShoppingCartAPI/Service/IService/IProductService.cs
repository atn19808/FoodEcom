using FoodEcom.Services.ShoppingCartAPI.Models.Dto;

namespace FoodEcom.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
