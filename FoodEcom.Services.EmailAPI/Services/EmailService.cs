using FoodEcom.Services.EmailAPI.Data;
using FoodEcom.Services.EmailAPI.Message;
using FoodEcom.Services.EmailAPI.Models;
using FoodEcom.Services.EmailAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FoodEcom.Services.EmailAPI.Services
{
    public class EmailService : IEmailService
    {
        private DbContextOptions<ApplicationDbContext> _dbOptions;

        public EmailService(DbContextOptions<ApplicationDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task EmailCartAndLog(CartDto cartDto)
        {
            StringBuilder message = new StringBuilder();

            message.AppendLine("<br />Cart Email Requested ");
            message.AppendLine("<br />Total " + cartDto.CartHeader.CartTotal);
            message.AppendLine("<br />");
            message.AppendLine("<ul> ");
            foreach (var item in cartDto.CartDetails)
            {
                message.Append("<li>");
                message.Append(item.Product.Name + " x " + item.Count);
                message.Append("</li>");
            }
            message.Append("</ul>");

            await LogAndEmail(message.ToString(), cartDto.CartHeader.Email);
        }

        public async Task LogOrderPlaced(RewardsMessage rewardsDto)
        {
            string message = "New Order Placed. <br/> Order Id: " + rewardsDto.OrderId;
            await LogAndEmail($"{message}", "dotnet@email.com");
        }

        public async Task RegisterUserEmailAndLog(string email)
        {
            string message = "User Registered Successful. <br/> Email: " + email;
            await LogAndEmail($"{message}", "dotnet@email.com");
        }

        private async Task<bool> LogAndEmail(string message, string email)
        {
            try
            {
                EmailLogger emailLog = new()
                {
                    Email = email,
                    EmailSent = DateTime.Now,
                    Message = message
                };
                await using var _db = new ApplicationDbContext(_dbOptions);
                _db.EmailLoggers.Add(emailLog);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
