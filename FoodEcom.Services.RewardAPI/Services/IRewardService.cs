using FoodEcom.Services.RewardAPI.Message;

namespace FoodEcom.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardMessage);
    }
}
