using Adapt.Core.Interfaces;
using Adapt.Core.Models;
using Adapt.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapt.Repository.RestaurantRepository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantsDbContext _context;

        public RestaurantRepository(RestaurantsDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Restaurant>> GetDetailedRestaurantListAsync()
        {
            var openRestaurantTime = await GetOpenRestaurantTime();

            var openBranches = await _context.Branches
            .Where(b => openRestaurantTime.Select(y => y.BranchId).Contains(b.BranchId))
            .ToListAsync();

            return await _context.Restaurants
            .Where(r => openBranches.Select(y => y.RestaurantId).Contains(r.RestaurantId))
            .ToListAsync();
        }

        public async Task<IList<Restaurant>> GetDetailedRestaurantListAsync(string postalCode)
        {
            var openRestaurantTime = await GetOpenRestaurantTime();

            var openBranches = await _context.Branches
            .Where(b => b.PostalCode == postalCode)
            .Where(b => openRestaurantTime.Select(y => y.BranchId).Contains(b.BranchId))
            .ToListAsync();

            return await _context.Restaurants
            .Where(r => openBranches.Select(y => y.RestaurantId).Contains(r.RestaurantId))
            .ToListAsync();
        }


        public async Task<IList<RestaurantTime>> GetOpenRestaurantTime()
        {
            var currentTime = DateTime.Now.TimeOfDay;
            var currentDayOfWeek = DateTime.Today.DayOfWeek;

            return await _context.RestaurantTimes
            .Where(r => r.OpenTime < currentTime && r.CloseTime > currentTime)
            .Where(r => (int)r.Day == (int)currentDayOfWeek)
            .ToListAsync();
        }
    }
}
