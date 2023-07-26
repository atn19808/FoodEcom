using FoodEcom.Services.AuthAPI.Models;

namespace FoodEcom.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
