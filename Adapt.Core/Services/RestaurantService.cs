using Adapt.Core.Interfaces;
using Adapt.Core.Models;
using Adapt.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapt.Core.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IRestaurantViewModelFactory _restaurantViewModelFactory;

        public RestaurantService(IRestaurantRepository restaurantsRepository, IRestaurantViewModelFactory restaurantViewModelFactory)
        {
            _restaurantRepository = restaurantsRepository;
            _restaurantViewModelFactory = restaurantViewModelFactory;
        }

        public async Task<IList<RestaurantViewModel>> GetDetailedRestaurantList()
        {
            var restaurants = await _restaurantRepository.GetDetailedRestaurantListAsync();

            return BuildRestaurantViewModel(restaurants);
        }

        public async Task<IList<RestaurantViewModel>> GetDetailedRestaurantList(string postalCode)
        {
            var restaurants = await _restaurantRepository.GetDetailedRestaurantListAsync(postalCode);

            return BuildRestaurantViewModel(restaurants);
        }

        private IList<RestaurantViewModel> BuildRestaurantViewModel(IList<Restaurant> restaurants)
        {
            var restaurantViewModels = _restaurantViewModelFactory.GetNewRestaurantViewModelList();

            foreach (var restaurant in restaurants)
            {
                foreach (var branch in restaurant.Branches)
                {
                    foreach (var restaurantTime in branch.RestaurantTime)
                    {
                        var restaurantViewModel = _restaurantViewModelFactory.GetNewRestaurantViewModel();
                        restaurantViewModel.RestaurantName = restaurant.Name;
                        restaurantViewModel.RestaurantId = restaurant.RestaurantId;
                        restaurantViewModel.RestaurantLogoName = restaurant.LogoName;
                        restaurantViewModel.BranchId = branch.BranchId;
                        restaurantViewModel.BranchName = branch.Name;
                        restaurantViewModel.BranchPostalCode = branch.PostalCode;
                        restaurantViewModel.BranchStreetName = branch.StreetName;
                        restaurantViewModel.BranchStreetNumber = branch.StreetNumber;
                        restaurantViewModel.BranchSuburb = branch.Suburb;
                        restaurantViewModel.OpeningTime = restaurantTime.OpenTime.ToString();
                        restaurantViewModel.ClosingTime = restaurantTime.CloseTime.ToString();

                        restaurantViewModels.Add(restaurantViewModel);
                    }
                }
            }
            return restaurantViewModels;
        }
    }
}
