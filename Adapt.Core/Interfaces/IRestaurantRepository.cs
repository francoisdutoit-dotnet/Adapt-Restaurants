using Adapt.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapt.Core.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<IList<Restaurant>> GetDetailedRestaurantListAsync();
        Task<IList<Restaurant>> GetDetailedRestaurantListAsync(string postalCode);
    }
}
