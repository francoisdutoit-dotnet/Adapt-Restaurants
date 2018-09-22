using System;
using System.Collections.Generic;
using System.Text;
using Adapt.Core.ViewModels;

namespace Adapt.Core.Interfaces
{
    public interface IRestaurantViewModelFactory
    {
        RestaurantViewModel GetNewRestaurantViewModel();
        IList<RestaurantViewModel> GetNewRestaurantViewModelList();
    }
}
