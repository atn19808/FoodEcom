using System.ComponentModel.DataAnnotations;

namespace FoodEcom.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
