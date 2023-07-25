using FoodEcom.Web.Models;

namespace FoodEcom.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto> SendAsync(RequestDto requestDto);
    }
}
