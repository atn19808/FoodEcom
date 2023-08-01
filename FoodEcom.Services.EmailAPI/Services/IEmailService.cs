using FoodEcom.Services.EmailAPI.Models.Dto;

namespace FoodEcom.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
    }
}
