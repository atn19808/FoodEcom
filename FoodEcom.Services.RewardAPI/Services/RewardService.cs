using Microsoft.EntityFrameworkCore;
using FoodEcom.Services.RewardAPI.Data;
using FoodEcom.Services.RewardAPI.Message;
using FoodEcom.Services.RewardAPI.Models;

namespace FoodEcom.Services.RewardAPI.Services
{
    public class RewardService : IRewardService
    {
        private DbContextOptions<ApplicationDbContext> _dbOptions;

        public RewardService(DbContextOptions<ApplicationDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task UpdateRewards(RewardsMessage rewardMessage)
        {
            try
            {
                Rewards rewards = new()
                {
                    OrderId = rewardMessage.OrderId,
                    RewardsActivity = rewardMessage.RewardsActivity,
                    UserId = rewardMessage.UserId,
                    RewardsDate = DateTime.Now,
                };

                await using var _db = new ApplicationDbContext(_dbOptions);
                await _db.Rewards.AddAsync(rewards);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
