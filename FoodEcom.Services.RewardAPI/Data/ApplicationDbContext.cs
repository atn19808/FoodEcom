﻿using FoodEcom.Services.RewardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodEcom.Services.RewardAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Rewards> Rewards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
