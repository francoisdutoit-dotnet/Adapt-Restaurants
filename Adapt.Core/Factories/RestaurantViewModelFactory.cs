using Adapt.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Adapt.Core.ViewModels;

namespace Adapt.Core.Factories
{
    public class RestaurantViewModelFactory : IRestaurantViewModelFactory
    {
        public RestaurantViewModel GetNewRestaurantViewModel()
        {
            return new RestaurantViewModel();
        }

        public IList<RestaurantViewModel> GetNewRestaurantViewModelList()
        {
            return new List<RestaurantViewModel>();
        }

    }
}
