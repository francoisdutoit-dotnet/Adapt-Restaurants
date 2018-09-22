using Adapt.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapt.Repository.Data
{
    public class RestaurantsDbContext : DbContext
    {
        public RestaurantsDbContext(DbContextOptions<RestaurantsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<RestaurantTime> RestaurantTimes { get; set; }
    }
}

