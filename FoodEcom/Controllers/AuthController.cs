using FoodEcom.Web.Models;
using FoodEcom.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace FoodEcom.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new LoginRequestDto();
            return View(loginRequestDto);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
