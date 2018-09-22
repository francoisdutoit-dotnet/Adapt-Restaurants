using Adapt.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapt.Core.Interfaces
{
    public interface IRestaurantService
    {
        Task<IList<RestaurantViewModel>> GetDetailedRestaurantList();
        Task<IList<RestaurantViewModel>> GetDetailedRestaurantList(string postalCode);
    }
}
