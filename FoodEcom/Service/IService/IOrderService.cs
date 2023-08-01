﻿using FoodEcom.Web.Models;

namespace FoodEcom.Web.Service.IService
{
    public interface IOrderService
    {
        Task<ResponseDto?> CreateOrder(CartDto cartDto);
    }
}
