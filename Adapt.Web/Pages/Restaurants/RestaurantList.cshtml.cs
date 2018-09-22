using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adapt.Core.Interfaces;
using Adapt.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Adapt.Web.Pages.Restaurants
{
    public class RestaurantListModel : PageModel
    {
        private readonly IRestaurantService _restaurantViewFactory;
        public IList<RestaurantViewModel> Restaurant { get; set; }

        public RestaurantListModel(IRestaurantService restaurantViewFactory)
        {
            _restaurantViewFactory = restaurantViewFactory;
        }

        public async Task OnGetAsync()
        {
            Restaurant = await _restaurantViewFactory.GetDetailedRestaurantList();
        }

        public async Task OnPostRestaurantsByPostalCode(string postalCode)
        {
            Restaurant = await _restaurantViewFactory.GetDetailedRestaurantList(postalCode);
        }

        public async Task OnPostRestaurantsByCurrentPostalCode(string currentPostalCode)
        {
            Restaurant = await _restaurantViewFactory.GetDetailedRestaurantList(currentPostalCode);
        }

        public async Task OnPostAllRestaurants()
        {
            Restaurant = await _restaurantViewFactory.GetDetailedRestaurantList();
        }
    }
}